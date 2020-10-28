using BlogREST_API.Interfaces;
using BlogREST_API.Models;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogREST_API.Repositories
{
    /// <summary>
    /// Class realizes methods of IBlogRepository interface
    /// </summary>
    public class BlogRepository:IBlogRepository
    {
        private readonly BlogContext _context;// database context
        private IMemoryCache cache; 

        public BlogRepository(BlogContext context, IMemoryCache memoryCache)
        {
            _context = context;
            cache = memoryCache;
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
            Blog blog = null;
            if (!cache.TryGetValue(id, out blog))
            {
                blog = _context.Blogs.FirstOrDefault(b => b.Id == id);
                if (blog != null)
                {
                    //caching
                    cache.Set(blog.Id, blog,
                    new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(5)));
                }
            }

            return blog;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
