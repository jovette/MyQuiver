using System;
using System.Collections.Generic;
using System.Text;
using MyQuiver.Common;
using MyQuiver.DataAccess.Model;
using MongoDB.Driver;
using MyQuiver.DataAccess.Filters;

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
            LimbFilter limbFilter = new LimbFilter
            {
                LimbId = id
            };

            var filter = GetFilterQuery<Limb, LimbFilter>(limbFilter);
            DeleteResult result = m_collection.DeleteOne(filter);
        }

        public List<Limb> FindByDrawWeight(int drawWeight)
        {
            LimbFilter limbFilter = new LimbFilter
            {
                DrawWeight = drawWeight
            };

            var filter = GetFilterQuery<Limb, LimbFilter>(limbFilter);
            var limbs = m_collection.Find(filter).ToList();
            return limbs;
        }

        public List<Limb> FindByLimbLength(LimbLength length)
        {
            LimbFilter limbFilter = new LimbFilter
            {
                LimbLengthType = length
            };

            var filter = GetFilterQuery<Limb, LimbFilter>(limbFilter);
            var limbs = m_collection.Find(filter).ToList();
            return limbs;
        }

        public List<Limb> FindByLimbMaterial(LimbMaterial material)
        {
            LimbFilter limbFilter = new LimbFilter
            {
                LimbMaterialType = material
            };

            var filter = GetFilterQuery<Limb, LimbFilter>(limbFilter);
            var limbs = m_collection.Find(filter).ToList();
            return limbs;
        }

        public Limb Get(int id)
        {
            LimbFilter limbFilter = new LimbFilter
            {
                LimbId = id
            };

            var filter = GetFilterQuery<Limb, LimbFilter>(limbFilter);
            var limb = m_collection.Find(filter).FirstOrDefault();

            return limb;
        }

        public void Update(Limb model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            LimbFilter limbFilter = new LimbFilter
            {
                LimbId = model.LimbId
            };

            var filter = GetFilterQuery<Limb, LimbFilter>(limbFilter);
            var updateDef = GetUpdateDefinition<Limb>(model);

            m_collection.UpdateOne(filter, updateDef);
        }
    }
}
