using Microsoft.EntityFrameworkCore;

namespace IntroProject.Data
{
    public class WebForumDbContext : DbContext
    {
        public WebForumDbContext(DbContextOptions<WebForumDbContext> options)
            : base(options)
        {
        }

        public DbSet<IntroProject.Models.Comment> Comment { get; set; } = default!;
        public DbSet<IntroProject.Models.Post> Post { get; set; } = default!;
        //public DbSet<IntroProject.Models.User> User { get; set; } = default!;
    }
}
