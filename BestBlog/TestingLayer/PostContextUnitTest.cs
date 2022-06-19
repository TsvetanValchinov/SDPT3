using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestingLayer
{
    public class PostContextUnitTest
    {
        private PostContext postContext;
        private UserContext userContext;
        private BestBlogDBContext dbContext;
        DbContextOptionsBuilder builder;
        User user;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            dbContext = new BestBlogDBContext(builder.Options);
            postContext = new PostContext(dbContext);
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            user = new User("Username", "Password");
        }

        [Test]
        public void TestCreatePost()
        {
            int postsBefore = postContext.ReadAll().Count();
            postContext.Create(new Post(user,"Proba"));
            int postsAfter = postContext.ReadAll().Count();
            Assert.IsTrue(postsBefore != postsAfter);
        }

        [Test]
        public void TestReadPost()
        {
            postContext.Create(new Post(user, "Proba"));
            Post post = postContext.Read(1);
            Assert.That(post != null, "There is no record with ID 1");
        }

        [Test]
        public void TestUpdatePost()
        {
            postContext.Create(new Post(user, "Proba"));
            Post post = postContext.Read(1);
            post.Title = "Proba2";
            postContext.Update(post);
            Post post1 = postContext.Read(1);
            Assert.IsTrue(post1.Title == "Proba2", "Post Update() does not change username!");


        }

        [Test]
        public void TestDeletePost()
        {
            postContext.Create(new Post(user, "Proba"));
            int postsBefore = postContext.ReadAll().Count();
            postContext.Delete(1);
            int postsAfter = postContext.ReadAll().Count();
            Assert.AreNotEqual(postsBefore, postsAfter);
        }
    }
}

