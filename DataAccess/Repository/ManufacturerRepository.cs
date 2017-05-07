using System;
using System.Collections.Generic;
using System.Text;
using MyQuiver.DataAccess.Model;
using MongoDB.Driver;

namespace MyQuiver.DataAccess.Repository
{
    public class ManufacturerRepository : MongoRepository, IManufactuerRepository
    {
        private IMongoCollection<Manufacturer> m_collection = null;
        public ManufacturerRepository(IMongoDatabase database) : base(database)
        {
            m_collection = Database.GetCollection<Manufacturer>(GetCollectionName<Manufacturer>());
        }

        public void Create(Manufacturer model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            m_collection.InsertOne(model);
        }

        public void Delete(int id)
        {
            var filter = Builders<Manufacturer>.Filter.Eq("Manufacturer", id);
            m_collection.DeleteOne(filter);
        }

        public List<Manufacturer> FindByName(string manufacturerName)
        {
            throw new NotImplementedException();
        }

        public Manufacturer Get(int id)
        {
            var filter = Builders<Manufacturer>.Filter.Eq("Manufacturer", id);
            var manufacturer = m_collection.Find(filter).FirstOrDefault();

            return manufacturer;
        }

        public void Update(Manufacturer model)
        {
            throw new NotImplementedException();
        }
    }
}
