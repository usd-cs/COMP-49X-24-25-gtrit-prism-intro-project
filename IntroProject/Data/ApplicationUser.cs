using IntroProject.Models;
using Microsoft.AspNetCore.Identity;

namespace IntroProject.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<WFPost> Posts { get; set; }

        public ICollection<WFComment> Comments { get; set; }
    }

}
