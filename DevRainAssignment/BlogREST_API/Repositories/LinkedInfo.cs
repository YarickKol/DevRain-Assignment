using BlogREST_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlogREST_API.Repositories
{
    public class LinkedInfo : ILinkedActions<Comment>
    {
        private readonly BlogContext _context;

        public LinkedInfo(BlogContext context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetLinkedInfo(int id)
        {
            return _context.Comments.Where(c => c.Blog.Id == id).ToList();
        }
    }
}
