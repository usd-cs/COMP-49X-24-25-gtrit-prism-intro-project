using Microsoft.AspNetCore.Identity;

namespace IntroProject.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public Boolean Admin { get; set; }
    }

}
