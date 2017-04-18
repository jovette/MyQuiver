using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using MongoDB.Driver;

using MyQuiver.DataAccess.Model;
using MyQuiver.DataAccess;
using MyQuiver.DataAccess.Repository;

namespace MyQuiver.Tests.DataAccess
{
    [TestClass]
    public class UserRepositoryTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateUserNullTest()
        {
            var mock = new Mock<IMongoDatabase>();

            mock.Setup(m => m.GetCollection<User>("Users", null)).Returns(new MongoCollectionMock<User>()).Verifiable();
            IUserRepository repository = new UserRepository(mock.Object);

            repository.Create(null);
        }

        [TestMethod]
        public void CreateUserTest()
        {
            var mock = new Mock<IMongoDatabase>();

            mock.Setup(m => m.GetCollection<User>("Users", null)).Returns(new MongoCollectionMock<User>()).Verifiable();
            IUserRepository repository = new UserRepository(mock.Object);

            User user = new User
            {
                Created = DateTime.UtcNow
            };

            repository.Create(user);
            mock.VerifyAll();
        }

        [TestMethod]
        public void DeleteUserTest()
        {
            var mock = new Mock<IMongoDatabase>();
            mock.Setup(m => m.GetCollection<User>("Users", null)).Returns(new MongoCollectionMock<User>()).Verifiable();
            IUserRepository repository = new UserRepository(mock.Object);

            repository.Delete(It.IsAny<int>());
            mock.VerifyAll();
        }
    }
}
