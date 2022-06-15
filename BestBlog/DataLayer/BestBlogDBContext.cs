using Microsoft.EntityFrameworkCore;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class BestBlogDBContext : DbContext
    {
        public BestBlogDBContext()
        {

        }

        public BestBlogDBContext(DbContextOptions options) 
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-JARQ3N6;Database=StanimirSofronov_30.05;Trusted_Connection=True;");
            }
        }



        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
