
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace BusinessLayer
{
     public class Comment
    {
        [Key]
        public int ID { get; private set; }
    }
}
