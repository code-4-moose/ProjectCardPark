using Microsoft.AspNetCore.Identity;

namespace ProjectCardPark.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ProjectCardParkUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
