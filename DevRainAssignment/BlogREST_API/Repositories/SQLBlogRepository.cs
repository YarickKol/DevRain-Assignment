using BlogREST_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogREST_API.Repositories
{
    public class SQLBlogRepository : IDefaultActions<Blog>
    {
        private readonly BlogContext _context;

        public SQLBlogRepository(BlogContext context)
        {
            _context = context;
        }

        public void CreateItem(Blog item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _context.Blogs.Add(item);
        }

        public IEnumerable<Blog> GetAllItems()
        {
            return _context.Blogs.ToList();
        }

        public Blog GetItemById(int id)
        {
            return _context.Blogs.FirstOrDefault(b => b.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

       
    }
}
