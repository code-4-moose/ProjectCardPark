using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCardPark.Data;

namespace ProjectCardPark.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<ProjectCardParkUser>(options)
    {
    }
}
