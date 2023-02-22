using convergence_backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace convergence_backend.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add 2 users
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    DateOfBirth = DateTime.Now,
                    FirstName = "Alexandre",
                    LastName = "Bourdeau"
                });

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    DateOfBirth = DateTime.Now,
                    FirstName = "Alexandre2",
                    LastName = "Bourdeau2"
                });
        }

        public List<ApplicationUser> getUsers() => Users.Local.ToList();
    }
}
