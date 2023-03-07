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

            /// ADDING USERS
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    DateOfBirth = DateTime.Now,
                    FirstName = "Elvis",
                    LastName = "Gratton"
                });

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    DateOfBirth = DateTime.Now,
                    FirstName = "Maurice",
                    LastName = "Richard"
                });

            /// ADDING EVENTS
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Title = "Badminton - Jeudi le 2 mars",
                    Description = "Venez jouer avec nous !",
                    DateTime = new DateTime(2023, 03, 02, 18, 30, 00),
                    LocationName = "Gymnase Saint-Henri",
                    LocationDetail = "Sonnez #001 si la porte est fermée",
                    DateCreated = DateTime.Now
                });
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 2,
                    Title = "Soccer",
                    Description = "Venez jouer avec nous !",
                    DateTime = new DateTime(2023, 03, 04, 15, 30, 00),
                    LocationName = "Gymnase Verdun",
                    LocationDetail = "Accéder au gymnase via la porte à droite sur la rue Morin",
                    DateCreated = DateTime.Now
                });
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 3,
                    Title = "Tournoi d'échecs",
                    Description = "Venez jouer avec nous !",
                    DateTime = new DateTime(2023, 03, 06, 9, 30, 00),
                    LocationName = "Bibliothèque Verdun",
                    LocationDetail = "Dans la salle secrète derrière le mur de livres",
                    DateCreated = DateTime.Now
                });
        }

        public List<ApplicationUser> getUsers() => Users.Local.ToList();
    }
}
