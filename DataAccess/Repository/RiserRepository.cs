using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using MyQuiver.DataAccess.Model;
using MyQuiver.DataAccess.Filters;

namespace MyQuiver.DataAccess.Repository
{
    public class RiserRepository : MongoRepository, IRiserRepository
    {
        private readonly IMongoCollection<Riser> m_collection = null;
        public RiserRepository(IMongoDatabase database) : base(database)
        {
            m_collection = Database.GetCollection<Riser>(GetCollectionName<Riser>());
        }

        public void Create(Riser model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            m_collection.InsertOne(model);
        }

        public void Delete(int id)
        {
            RiserFilter filter = new RiserFilter
            {
                RiserId = id
            };

            var query = GetFilterQuery<Riser, RiserFilter>(filter);
            m_collection.DeleteOne(query);
        }

        public List<Riser> FindByLength(int riserLength)
        {
            RiserFilter riserFilter = new RiserFilter
            {
                RiserLength = riserLength
            };

            return FindRisers(riserFilter);
        }

        public List<Riser> FindByManufacturer(string manufacturer)
        {
            RiserFilter riserFilter = new RiserFilter
            {
                Manufacturers = new List<ManufacturerFilter>() { new ManufacturerFilter { Name = manufacturer } }
            };

            return FindRisers(riserFilter);
        }

        public List<Riser> FindByModel(string modelName)
        {
            RiserFilter riserFilter = new RiserFilter
            {
                ModelName=modelName
            };

            return FindRisers(riserFilter);
        }

        public List<Riser> FindByRiserMaterialType(string materialType)
        {
            RiserFilter riserFilter = new RiserFilter
            {
                RiserMaterialType = materialType
            };

            return FindRisers(riserFilter);
        }

        public Riser Get(int id)
        {
            RiserFilter filter = new RiserFilter
            {
                RiserId = id
            };

            var query = GetFilterQuery<Riser, RiserFilter>(filter);
            var riser = m_collection.Find(query).FirstOrDefault();
            return riser;
        }

        public void Update(Riser model)
        {
            RiserFilter filter = new RiserFilter
            {
                RiserId = model.RiserId
            };

            var query = GetFilterQuery<Riser, RiserFilter>(filter);
            var updateDef = GetUpdateDefinition<Riser>(model);
            m_collection.UpdateOne(query, updateDef);
        }

        private List<Riser> FindRisers(RiserFilter riserFilter)
        {
            var filter = GetFilterQuery<Riser, RiserFilter>(riserFilter);
            var risers = m_collection.Find(filter).ToList();
            return risers;
        }
    }
}
