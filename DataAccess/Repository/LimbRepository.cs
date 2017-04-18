using System;
using System.Collections.Generic;
using System.Text;
using MyQuiver.Common;
using MyQuiver.DataAccess.Model;
using MongoDB.Driver;

namespace MyQuiver.DataAccess.Repository
{
    public class LimbRepository : MongoRepository, ILimbRepository
    {
        private IMongoCollection<Limb> m_collection = null;

        public LimbRepository(IMongoDatabase database) : base(database)
        {
            m_collection = Database.GetCollection<Limb>(GetCollectionName<Limb>());
        }

        public void Create(Limb model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            m_collection.InsertOne(model);
        }

        public void Delete(int id)
        {
            var filter = Builders<Limb>.Filter.Eq("LimbId", id);
            DeleteResult result = m_collection.DeleteOne(filter);
        }

        public List<Limb> FindByDrawWeight(int drawWeight)
        {
            throw new NotImplementedException();
        }

        public List<Limb> FindByLimbLength(LimbLength length)
        {
            throw new NotImplementedException();
        }

        public List<Limb> FindByLimbMaterial(LimbMaterial material)
        {
            throw new NotImplementedException();
        }

        public Limb Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Limb model)
        {
            throw new NotImplementedException();
        }
    }
}
