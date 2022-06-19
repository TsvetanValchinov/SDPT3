using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace ServiceLayer
{
    public class DbContextManager
    {
        private static BestBlogDBContext _context;

        public static BestBlogDBContext CreateContext()
        {
            _context = new BestBlogDBContext();
            return _context;
        }

        public static BestBlogDBContext GetContext()
        {
            return _context;
        }

        public static void SetChangeTracking(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }
    }
}
