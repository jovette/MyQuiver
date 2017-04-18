using System;
using System.Collections.Generic;

using MongoDB.Driver;

using MyQuiver.DataAccess.Model;
using MyQuiver.DataAccess.Filters;

namespace MyQuiver.DataAccess.Repository
{
    public class UserRepository : MongoRepository, IUserRepository
    {
        private IMongoCollection<User> m_collection = null;

        public UserRepository(IMongoDatabase database) : base(database)
        {
            m_collection = Database.GetCollection<User>(GetCollectionName<User>());
        }

        public void Create(User model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            m_collection.InsertOne(model);
        }

        public void Delete(int id)
        {
            UserFilter filter = new UserFilter
            {
                UserId = id
            };

            var filterQuery = GetFilterQuery<User, UserFilter>(filter);
            var result = m_collection.DeleteMany(filterQuery);
        }

        public List<User> FindUsers(UserFilter filter)
        {
            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            var filterQuery = GetFilterQuery<User, UserFilter>(filter);
            var users = m_collection.Find(filterQuery);

            return users.ToList();
        }

        public User Get(int id)
        {
            UserFilter filter = new UserFilter
            {
                UserId = id
            };

            var filterQuery = GetFilterQuery<User, UserFilter>(filter);

            var user = m_collection.Find(filterQuery, new FindOptions
            {
                AllowPartialResults = false,
                CursorType = CursorType.NonTailable
            }).FirstOrDefault();
            return user;
        }

        public User GetByEmail(string emailAddress)
        {
            UserFilter filter = new UserFilter
            {
                PrimaryEmail=emailAddress
            };

            var filterQuery = GetFilterQuery<User, UserFilter>(filter);

            var user = m_collection.Find(filterQuery, new FindOptions
            {
                AllowPartialResults = false,
                CursorType = CursorType.NonTailable
            }).FirstOrDefault();
            return user;
        }

        public void Update(User model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            UserFilter filter = new UserFilter
            {
                UserId = model.UserId
            };

            var filterQuery = GetFilterQuery<User, UserFilter>(filter);
            UpdateDefinition<User> updateQuery = GetUpdateDefinition<User>(model);

            var result = m_collection.UpdateMany(filterQuery, updateQuery);
        }
    }
}
