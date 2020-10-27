using BlogREST_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogREST_API
{
    /// <summary>
    /// Context of database Entity Framework
    /// </summary>
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
