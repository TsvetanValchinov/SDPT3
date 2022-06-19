using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;
using System.Linq;

namespace ServiceLayer
    {
    public class UserManager : IRepository<User, int>
        {
        private UserContext _userContext;

        public UserManager(BestBlogDBContext context)
            {
            _userContext = new UserContext(context);
            }

        public void Create(User item)
            {
            try
                {
                if(ValidateUsername(item.Username))
                    {
                    _userContext.Create(item);
                    }
                else
                    {
                    throw new ArgumentException("This username is already used. Please choose other username!");  
                    }
                }
            catch (Exception ex)
                { 
                throw ex;
                }
            }

        public User Read(int key)
            {
            try
                {
                return _userContext.Read(key);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<User> Read(int skip, int take)
            {
            try
                {
                return _userContext.Read(skip, take);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public IEnumerable<User> ReadAll()
            {
            try
                {
                return _userContext.ReadAll();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        public void Update(User item)
            {
            try
                {
                _userContext.Update(item);
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
                _userContext.Delete(key);
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }
        // return TRUE if there is NO user with that username or FALSE if there is user with that username 
        protected bool ValidateUsername(string username)
            {
            IEnumerable<User> users = _userContext.ReadAll();
            List<string> usernames = new List<string>();
            foreach(User user in users)
                {
                usernames.Add(user.Username);
                }
            bool check = true;
            foreach(string usernameFromDb in usernames)
                {
                if(usernameFromDb==username)
                    {
                    check = false;
                    }
                }
            return check;
            }
       
        public User CheckForUser(string username, string password)
            {
            IEnumerable<User> users = _userContext.ReadAll();
            foreach (User user in users)
                {
                if(user.Username == username && user.Password == password)
                    {
                    return user;
                    }
                }
            return null;
            }

        public bool CheckIfUsernameIsUsed(string username)
            {
            IEnumerable<User> users = _userContext.ReadAll();
            foreach (User user in users)
                {
                if (user.Username == username)
                    {
                    return true;
                    }
                }
            return false;
            }

        public User findUserByUsername(string username)
            {
            IEnumerable<User> users = _userContext.ReadAll();
            foreach(User user in users)
                {
                if(user.Username == username)
                    {
                    return user;
                    }
                }
            return null;
            }

    
        }
    }
