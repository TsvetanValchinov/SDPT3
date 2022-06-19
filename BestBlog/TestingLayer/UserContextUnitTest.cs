using NUnit.Framework;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace TestingLayer
{
    public class UserContextUnitTest

    {
        private UserContext userContext;
        private BestBlogDBContext dbContext;
        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            dbContext = new BestBlogDBContext(builder.Options);
            userContext = new UserContext(dbContext);
        }

        [Test]
        public void TestCreateUser()
        {
            int usersBefore = userContext.ReadAll().Count();
            userContext.Create(new User("MartinBrat", "1234"));
            int usersAfter = userContext.ReadAll().Count();
            Assert.IsTrue(usersBefore != usersAfter);
        }

        [Test]
        public void TestReadUser()
        {
            userContext.Create(new User("MartinBrat", "1234"));
            User user = userContext.Read(1);
            Assert.That(user != null,"There is no record with ID 1"); 
        }

        [Test]
        public void TestUpdateUser()
        {
            userContext.Create(new User("MartinBrat", "1234"));
            User user = userContext.Read(1);
            user.Username = "Martin_E_gOTIN";
            userContext.Update(user);
            User user1 = userContext.Read(1);
            Assert.IsTrue(user1.Username == "Martin_E_gOTIN", "User Update() does not change username!");


        }

        [Test]
        public void TestDeleteUser()
        {
            userContext.Create(new User("MartinBrat", "1234"));
            int usersBefore = userContext.ReadAll().Count();
            userContext.Delete(1);
            int usersAfter = userContext.ReadAll().Count();
            Assert.AreNotEqual(usersBefore, usersAfter);
        }
    }
}