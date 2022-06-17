using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer.Controllers
{
    public class PostManager : IRepository<Post, int>
    {
        private PostContext _postRepository;

        public PostManager(BestBlogDBContext context)
        {
            _postRepository = new PostContext(context);
        }

        public void Create(Post item)
        {
            try
            {
                _postRepository.Create(item);
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
                return _postRepository.Read(key);
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
                return _postRepository.Read(skip, take);
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
                return _postRepository.ReadAll();
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
                _postRepository.Update(item);
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
                _postRepository.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
