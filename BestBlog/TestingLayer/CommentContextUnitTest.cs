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
    public class CommentContextUnitTest
    {
        private CommentContext commentContext;
        private PostContext postContext;
        private UserContext userContext;
        private BestBlogDBContext dbContext;
        DbContextOptionsBuilder builder;
        User user;
        Post post;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            dbContext = new BestBlogDBContext(builder.Options);
            commentContext = new CommentContext(dbContext);
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            user = new User("Username", "Password");
            post = new Post(user, "Title");
        }

        [Test]
        public void TestCreateComment()
        {
            int commentsBefore = commentContext.ReadAll().Count();
            commentContext.Create(new Comment("OK",post,user));
            int commentsAfter = commentContext.ReadAll().Count();
            Assert.IsTrue(commentsBefore != commentsAfter);
        }

        [Test]
        public void TestReadComment()
        {
            commentContext.Create(new Comment("OK", post, user));
            Comment comment = commentContext.Read(1);
            Assert.That(comment != null, "There is no record with ID 1");
        }

        [Test]
        public void TestUpdateComment()
        {
            commentContext.Create(new Comment("OK", post, user));
            Comment comment = commentContext.Read(1);
            comment.Content = "DObre";
            commentContext.Update(comment);
            Comment comment1 = commentContext.Read(1);
            Assert.IsTrue(comment1.Content == "DObre", "Comment Update() does not change username!");


        }

        [Test]
        public void TestDeleteComment()
        {
            commentContext.Create(new Comment("OK", post, user));
            int commentsBefore = commentContext.ReadAll().Count();
            commentContext.Delete(1);
            int commentsAfter = commentContext.ReadAll().Count();
            Assert.AreNotEqual(commentsBefore, commentsAfter);
        }
    }
}

