using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class CommentManager : IRepository<Comment, int>
    {
        private CommentContext _commentContext;

        public CommentManager(BestBlogDBContext context)
        {
            _commentContext = new CommentContext(context);
        }

        public void Create(Comment item)
        {
            try
            {
                _commentContext.Create(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Comment Read(int key)
        {
            try
            {
                return _commentContext.Read(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Comment> Read(int skip, int take)
        {
            try
            {
                return _commentContext.Read(skip, take);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Comment> ReadAll()
        {
            try
            {
                return _commentContext.ReadAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Comment item)
        {
            try
            {
                _commentContext.Update(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(int key)
        {
            try
            {
                _commentContext.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}