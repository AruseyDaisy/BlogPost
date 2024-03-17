using Microsoft.EntityFrameworkCore;

namespace Blog_post_API.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
        : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;
    }
}
