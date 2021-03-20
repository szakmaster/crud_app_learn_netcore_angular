using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogPostsContext : DbContext
    {
        public BlogPostsContext (DbContextOptions<BlogPostsContext> options)
            : base(options)
        {
        }

        public DbSet<Blog.Models.BlogPost> BlogPost { get; set; }
    }
}
