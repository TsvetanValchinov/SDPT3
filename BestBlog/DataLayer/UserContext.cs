using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataLayer
{
     public class UserContext : IDB<User, int>
    {
        private BestBlogDBContext _context;

        public UserContext(BestBlogDBContext context)
        {
            this._context = context;
        }

        public void Create(User item)
        {
            try
            {
                _context.Users.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User Read(int key, bool noTracking = false, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<User> users = _context.Users;

                if (noTracking)
                {
                    users = users.AsNoTrackingWithIdentityResolution();
                }

                if (useNavigationProperties)
                {
                    users = users.Include(u => u.Posts).Include(u => u.Comments);
                }

                User userFromDB = users.SingleOrDefault(u => u.ID == key);

                if (userFromDB == null)
                {
                    throw new ArgumentException("There is no user with that id!");
                }

                return userFromDB;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<User> Read(int skip, int take, bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<User> users = _context.Users.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                {
                    users = users.Include(u => u.Posts).Include(u => u.Comments);
                }

                return users.Skip(skip).Take(take).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<User> ReadAll(bool useNavigationProperties = false)
        {
            try
            {
                IQueryable<User> users = _context.Users.AsNoTrackingWithIdentityResolution();

                if (useNavigationProperties)
                {
                    users = users.Include(u => u.Posts).Include(u => u.Comments);
                }

                return users.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(User item, bool useNavigationProperties = false)
        {
            try
            {
                User userFromDb = Read(item.ID);
                _context.Entry(userFromDb).CurrentValues.SetValues(item);
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
                _context.Users.Remove(Read(key));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

