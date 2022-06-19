
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BusinessLayer
{
    public class Comment
    {
        [Key]
        public int ID { get; private set; }

        [Required, MaxLength(32000)]
        public string Content { get; set; }

        [ForeignKey("Post")]
        public int PostID { get; set; }

        [Required]
        public Post Post { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [Required]
        public User User { get; set; }

        public DateTime Created_On { get; set; }


        private Comment()
        {

        }

        public Comment(string content, Post post, User user)
        {
            this.Content = content;
            this.PostID = post.ID;
            this.UserID = user.ID;
            this.Created_On = DateTime.Now;
        }
    }
}
