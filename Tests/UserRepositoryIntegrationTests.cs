using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MongoDB.Driver;

using MyQuiver.DataAccess.Model;
using MyQuiver.DataAccess;
using MyQuiver.DataAccess.Repository;
using MyQuiver.Common;

namespace MyQuiver.Tests.DataAccess
{
    [TestClass]
    public class UserRepositoryIntegrationTests
    {
        private const string CONNECT_URL = "";
        private const string DATABASE = "MyQuiver";

        private IMongoDatabase m_database = null;

        public void InitTest()
        {
            m_database = DatabaseFactory.GetDatabase(CONNECT_URL, DATABASE);
        }

        [TestMethod]
        public void TestCreate()
        {
            IUserRepository repo = new UserRepository(m_database);

            User user = new User
            {
                Age = 42,
                Created = DateTime.Now,
                FirstName = "Integration",
                LastName = "Test",
                PostalCode = "92101",
                PreferredStyle = BowType.Recurve,
                PrimaryEmail = "int.test.55@test.com",
                State = "CA",
                Provider = AuthenicationProvider.Microsoft,
                ProviderToken = "ofmyaffection",
                Type = UserType.Administrator,
                Status = UserStatus.Terminated
            };
        }
    }
}
