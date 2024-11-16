using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IntroProject.Models;

namespace IntroProject.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<IntroProject.Models.Comment> Comment { get; set; } = default!;
        public DbSet<IntroProject.Models.Post> Post { get; set; } = default!;
        public DbSet<IntroProject.Models.User> User { get; set; } = default!;
    }
}
