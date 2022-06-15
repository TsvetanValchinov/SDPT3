using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace BusinessLayer
{
    public  class Post
    {
        [Key]
        public int ID { get; private set; }
    }
}
