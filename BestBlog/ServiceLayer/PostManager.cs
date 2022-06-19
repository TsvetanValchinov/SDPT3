using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class PostManager : IRepository<Post, int>
    {
        private PostContext _postContext;

        public PostManager(BestBlogDBContext context)
        {
            _postContext = new PostContext(context);
        }

        public void Create(Post item)
        {
            try
            {
                _postContext.Create(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Post Read(int key)
        {
            try
            {
                return _postContext.Read(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Post> Read(int skip, int take)
        {
            try
            {
                return _postContext.Read(skip, take);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Post> ReadAll()
        {
            try
            {
                return _postContext.ReadAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Post item)
        {
            try
            {
                _postContext.Update(item);
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
                _postContext.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
