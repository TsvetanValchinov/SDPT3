using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class CommentContext : IDB<Comment, int>
    {
        private BestBlogDBContext _context;

        public CommentContext(BestBlogDBContext context)
        {
            this._context = context;
        }

        public void Create(Comment item)
        {
            try
            {
                _context.Comments.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Comment Read(int key, bool noTracking = false, bool useNavigationProperties = false)
        {
            try
            {

                IQueryable<Comment> comments = _context.Comments;

                if (noTracking)
                {
                    comments = comments.AsNoTrackingWithIdentityResolution();
                }

                if (useNavigationProperties)
                {
                    comments = comments.Include(c => c.Post).Include(c => c.User);
                }

                Comment commentFromDB = comments.SingleOrDefault(c => c.ID == key);

                if (commentFromDB == null)
                {
                    throw new ArgumentException("There is no comment with that id!");
                }

                return commentFromDB;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Comment> Read(int skip, int take, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Comment> comments = _context.Comments.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                {
                    comments = comments.Include(c => c.Post).Include(c => c.User);
                }

                return comments.Skip(skip).Take(take).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Comment> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<Comment> comments = _context.Comments.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                {
                    comments = comments.Include(c => c.Post).Include(c => c.User);
                }

                return comments.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Comment item, bool useNavigationProperties = false)
        {
            try
            {
                Comment commentFromDB = Read(item.ID);
                _context.Entry(commentFromDB).CurrentValues.SetValues(item);
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
                _context.Comments.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
