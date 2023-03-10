using convergence_backend.Entities;
using convergence_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace convergence_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add some users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "username1",
                    Password = "password1",
                    Email = "username1@gmail.com"
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 2,
                    Username = "username2",
                    Password = "password2",
                    Email = "username2@gmail.com"
                });

            // Add some events
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Title = "Badminton - Jeudi le 2 mars",
                    Description = "Venez jouer avec nous ! \n\nLorem ipsum dolor sit amet, consectetur adipiscing " +
                    "elit. In non dapibus leo. Nunc feugiat dapibus ipsum quis pretium. Quisque non ultricies arcu, " +
                    "non auctor nisi. Phasellus faucibus eros a ante blandit, ut dapibus ex blandit. Quisque quis " +
                    "tristique magna. Aenean venenatis justo lobortis massa efficitur, ut vehicula ex eleifend. " +
                    "Curabitur ornare, quam ut blandit pretium, augue mauris commodo erat, a aliquam odio neque sed " +
                    "mi. Proin nec erat justo. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce tempor " +
                    "efficitur tortor, sit amet elementum leo ornare nec. Proin sodales velit sed lorem elementum, a " +
                    "varius dui ullamcorper. Donec laoreet molestie turpis, quis rhoncus sapien faucibus ut. In " +
                    "sagittis accumsan arcu pulvinar imperdiet. Duis eleifend dolor eu purus laoreet mattis. Fusce " +
                    "sed metus risus.\n\nDonec eget lorem cursus, pellentesque ipsum in, volutpat mi. Proin ultrices, " +
                    "erat sed fringilla fermentum, massa odio pulvinar tellus, non pulvinar quam urna vitae massa. " +
                    "Vivamus convallis sollicitudin placerat. Suspendisse vitae sollicitudin lorem. Pellentesque " +
                    "vehicula augue id pharetra ultricies. Aenean id mi finibus, molestie urna vitae, convallis eros. " +
                    "Quisque mollis enim vitae odio tincidunt, et ullamcorper diam dictum. Fusce feugiat neque eu " +
                    "dapibus malesuada. Cras condimentum vestibulum diam. Duis aliquam, ex interdum molestie commodo, " +
                    "diam justo ullamcorper purus, facilisis consectetur lorem justo eu sem. Nulla in augue non dui " +
                    "dignissim accumsan. ",
                    DateTimeStart = new DateTime(2023, 03, 02, 18, 30, 00),
                    DateTimeEnd = new DateTime(2023, 03, 02, 20, 30, 00),
                    LocationName = "Gymnase Saint-Henri",
                    LocationDetail = "Sonnez #001 si la porte est fermée",
                });
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 2,
                    Title = "Soccer",
                    Description = "Venez jouer avec nous ! Vivamus elementum ultrices ligula nec efficitur. Quisque " +
                    "dictum accumsan euismod. Praesent risus neque, elementum ut nunc non, lobortis efficitur " +
                    "ligula. Proin egestas bibendum libero quis tempor. Etiam iaculis sem sed tortor viverra " +
                    "tempus. Nulla luctus congue enim, sit amet viverra nulla viverra nec. Nam nec ipsum faucibus, " +
                    "ultricies augue vel, tristique orci. Aenean et nunc vulputate, commodo felis vel, euismod " +
                    "sapien. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. " +
                    "Vestibulum quis elementum urna, quis rhoncus sem. Cras ac ultrices turpis. Phasellus id dolor " +
                    "non erat pretium imperdiet id nec elit.\r\n\r\nCras feugiat tellus quis arcu egestas, sed " +
                    "mollis enim congue. Nulla convallis mollis pellentesque. Curabitur feugiat eros at metus " +
                    "ornare, et cursus ex pharetra. Etiam fermentum, orci vitae commodo volutpat, dolor eros " +
                    "facilisis libero, a elementum magna ante eget sapien. Vivamus eu urna non lorem aliquam " +
                    "fringilla in id sapien. Cras blandit ex in urna interdum, sed fermentum massa lobortis. " +
                    "Maecenas accumsan pulvinar purus quis faucibus. Curabitur leo neque, pharetra eu nunc in, " +
                    "bibendum cursus lectus. Donec fringilla eget odio non pellentesque. Nam eget venenatis sapien, " +
                    "non fringilla lacus. Donec blandit ornare nulla, id porta libero porta eget. Sed ultricies " +
                    "tincidunt sapien. ",
                    DateTimeStart = new DateTime(2023, 03, 04, 15, 30, 00),
                    DateTimeEnd = new DateTime(2023, 03, 04, 17, 30, 00),
                    LocationName = "Gymnase Verdun",
                    LocationDetail = "Accéder au gymnase via la porte à droite sur la rue Morin",
                });
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 3,
                    Title = "Tournoi d'échecs",
                    Description = "Venez jouer avec nous !",
                    DateTimeStart = new DateTime(2023, 03, 06, 9, 30, 00),
                    DateTimeEnd = new DateTime(2023, 03, 06, 12, 30, 00),
                    LocationName = "Bibliothèque Verdun",
                    LocationDetail = "Dans la salle secrète derrière le mur de livres",
                });
        }
    }
}
