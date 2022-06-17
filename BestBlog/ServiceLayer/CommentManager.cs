using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer.Controllers
{
    public class CommentManager : IRepository<Comment, int>
    {
        private CommentContext _commentRepository;

        public CommentManager(BestBlogDBContext context)
        {
            _commentRepository = new CommentContext(context);
        }

        public void Create(Comment item)
        {
            try
            {
                _commentRepository.Create(item);
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
                return _commentRepository.Read(key);
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
                return _commentRepository.Read(skip, take);
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
                return _commentRepository.ReadAll();
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
                _commentRepository.Update(item);
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
                _commentRepository.Delete(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}