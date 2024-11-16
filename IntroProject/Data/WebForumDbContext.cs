using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IntroProject.Data
{
    public class WebForumDbContext(DbContextOptions<WebForumDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    }
}
