using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class PostContext : IDB<Post, int>
    {
        private BestBlogDBContext _context;

        public PostContext(BestBlogDBContext context)
        {
            this._context = context;
        }

        public void Create(Post item)
        {
            try
            {
                _context.Posts.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Post Read(int key, bool noTracking = false, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Post> posts = _context.Posts;

                if (noTracking)
                {
                    posts = posts.AsNoTrackingWithIdentityResolution();
                }

                if (useNavigationProperties)
                {
                    posts = posts.Include(p => p.User).Include(p => p.Comments);
                }

                Post postFromDB = posts.SingleOrDefault(p => p.ID == key);

                if (postFromDB == null)
                {
                    throw new ArgumentException("There is no post with that id!");
                }

                return postFromDB;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Post> Read(int skip, int take, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Post> posts = _context.Posts.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                {
                    posts = posts.Include(p => p.User).Include(p => p.Comments);
                }

                return posts.Skip(skip).Take(take).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Post> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Post> posts = _context.Posts.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                {
                    posts = posts.Include(p => p.User).Include(p => p.Comments);
                }

                return posts.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Post item, bool useNavigationProperties = false)
        {
            try
            {
                Post postFromDB = Read(item.ID);
                _context.Entry(postFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
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
                _context.Posts.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
