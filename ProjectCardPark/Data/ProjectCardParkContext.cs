using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCardPark.Data;

namespace ProjectCardPark.Data
{
    public class ProjectCardParkContext(DbContextOptions<ProjectCardParkContext> options) : IdentityDbContext<ProjectCardParkUser>(options)
    {
        public DbSet<ProjectKard.Domain.Admin> Admin { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Cards> Cards { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Category> Category { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Delivery> Delivery { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Listing> Listing { get; set; } = default!;
        public DbSet<ProjectKard.Domain.Rating> Rating { get; set; } = default!;
        public DbSet<ProjectKard.Domain.User> User { get; set; } = default!;
    }
}
