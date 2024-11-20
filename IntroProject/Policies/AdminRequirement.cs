using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System.Security.Claims;

namespace IntroProject.Policies;

    public class AdminRequirement : IAuthorizationRequirement
{
    public class AdminAuthorizationHandler : AuthorizationHandler<AdminRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AdminRequirement requirement)
        {
            if (context.User.HasClaim(c => c.Type == "Admin" && c.Value == "true"))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
