using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using MongoDB.Driver;

namespace MyQuiver.DataAccess.Repository
{
    public abstract class MongoRepository
    {
        private IMongoDatabase m_database = null;

        protected MongoRepository(IMongoDatabase database)
        {
            m_database = database;
        }

        /// <summary>
        /// Get the name of the collection based off the model. Will appropriatly pluralize
        /// </summary>
        /// <typeparam name="TModel">The type of the model to use</typeparam>
        /// <returns>The name of the collection</returns>
        protected static string GetCollectionName<TModel>()
        {
            Type modelType = typeof(TModel);
            string modelName = modelType.Name;
            string collectionName = string.Empty;
            char endingCharacter = modelName[modelName.Length - 1];

            //Be smart about English
            if (char.ToLowerInvariant(endingCharacter) == 'y')
            {
                char nextChar = modelName[modelName.Length - 2];
                char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
                if (vowels.Any(v => v == nextChar))
                    collectionName = string.Concat(modelName, 's'); //bays, toys, keys
                else
                    collectionName = string.Concat(modelName.Substring(0, modelName.Length - 2), "ies"); //histories, flies, countries, etc.
            }
            else if (char.ToLowerInvariant(endingCharacter) == 'o') //Gonna have the odd case here...pianoes
            {
                collectionName = string.Concat(modelName, "es");
            }
            else
                collectionName = string.Concat(modelName, 's'); //Bows, Arrows

            return collectionName;
        }

        /// <summary>
        /// Generate a MongoDB filter definition for querying
        /// </summary>
        /// <typeparam name="TModel">The type of the model to use</typeparam>
        /// <typeparam name="TFilter">The type of filter to apply</typeparam>
        /// <param name="filter">The filter object to filter the collection of models</param>
        /// <returns>The filter definition query for the Mongo collection</returns>
        protected static FilterDefinition<TModel> GetFilterQuery<TModel, TFilter>(TFilter filter)
        {
            Type filterType = typeof(TFilter);
            var properties = filterType.GetProperties();

            var builder = Builders<TModel>.Filter;
            List<FilterDefinition<TModel>> filters = new List<FilterDefinition<TModel>>();

            foreach (var property in properties)
            {
                object propertyValue = property.GetValue(filter);
                if (propertyValue == null)
                    continue;

                if (property.PropertyType.IsInstanceOfType(typeof(List<>)))
                {
                    Type listType = property.PropertyType.GetGenericArguments()[0];

                    //TODO: Figure this out somehow..
                    //builder.In(property.Name, propertyValue);
                }
                else
                {
                    var filterParameter = builder.Eq(property.Name, propertyValue);
                    filters.Add(filterParameter);
                }
            }
            var query = builder.And(filters);
            return query;
        }

        /// <summary>
        /// Get the update definition query for updating
        /// </summary>
        /// <typeparam name="TModel">The type of the model to use</typeparam>
        /// <param name="model">The model to be updated</param>
        /// <returns>The update definition</returns>
        protected static UpdateDefinition<TModel> GetUpdateDefinition<TModel>(TModel model)
        {
            Type modelType = typeof(TModel);

            List<UpdateDefinition<TModel>> updateFields = new List<UpdateDefinition<TModel>>();
            var modelProperties = modelType.GetProperties();

            var updateBuilder = Builders<TModel>.Update;
            foreach (var property in modelProperties)
            {
                var propertyValue = property.GetValue(model);
                var update = updateBuilder.Set(property.Name, propertyValue);
                updateFields.Add(update);
            }

            var updateQuery = updateBuilder.Combine(updateFields);
            return updateQuery;
        }

        public IMongoDatabase Database { get => m_database; }
    }
}
