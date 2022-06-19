using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
     public class User
    {
        [Key]
        public int ID { get; private set; }

        [Required, MaxLength(64)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public IEnumerable<Post> Posts { get; set; }// stores the posts of this user

        public IEnumerable<Comment> Comments { get; set; }// stores the comments of this user
        private User()
        {

        }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}

