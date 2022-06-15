using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Post
    {
        [Key]
        public int ID { get; private set; }

        [MaxLength(200), Required]
        public string Title { get; set; }

        [MaxLength(32000)]
        public string Content { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [Required]
        public User User { get; set; }

        public DateTime Created_On { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

        private Post()
        {

        }

        public Post(User user, string title)
        {
            this.User = user;
            this.Title = title;
            this.Created_On = DateTime.Now;
        }
    }
}
