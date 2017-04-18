using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuiver.DataAccess
{
    public static class DatabaseFactory
    {
        //Static client so to avoid repetitiously creating client references
        private static MongoClient m_client = null;

        /// <summary>
        /// Get a reference to a Mongo document database
        /// </summary>
        /// <param name="connectUrl">The URL of the MongoDB server</param>
        /// <param name="database">The name of the database</param>
        /// <returns>A MongoDB reference</returns>
        public static IMongoDatabase GetDatabase(string connectUrl, string database)
        {
            MongoClientSettings settings = new MongoClientSettings
            {
                ConnectionMode = ConnectionMode.Automatic,
                UseSsl = true,
                ApplicationName = database,
                Server = new MongoServerAddress(connectUrl)
            };
            if (m_client == null)
                m_client = new MongoClient(settings);

            IMongoDatabase mongoDB = m_client.GetDatabase(database);
            return mongoDB;
        }
    }
}
