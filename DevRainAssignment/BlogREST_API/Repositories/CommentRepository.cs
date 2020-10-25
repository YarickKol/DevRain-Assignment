using BlogREST_API.Interfaces;
using BlogREST_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogREST_API.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogContext _context;

        public CommentRepository(BlogContext context)
        {
            _context = context;
        }
        public void CreateItem(Comment item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _context.Comments.Add(item);
        }

        public IEnumerable<Comment> GetAllItems()
        {
            return _context.Comments.ToList();
        }

        public Comment GetItemById(int id)
        {
            return _context.Comments.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public IEnumerable<Comment> GetLinkedInfo(int id)
        {
            return _context.Comments.Where(c => c.Blog.Id == id).ToList();
        }
    }
}
