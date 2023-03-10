using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace convergence_backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DateTimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocationDetail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTimeUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "DateTimeCreated", "DateTimeEnd", "DateTimeStart", "Description", "LocationDetail", "LocationName", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 10, 4, 56, 9, 313, DateTimeKind.Utc).AddTicks(5896), new DateTime(2023, 3, 2, 20, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), "Venez jouer avec nous ! \n\nLorem ipsum dolor sit amet, consectetur adipiscing elit. In non dapibus leo. Nunc feugiat dapibus ipsum quis pretium. Quisque non ultricies arcu, non auctor nisi. Phasellus faucibus eros a ante blandit, ut dapibus ex blandit. Quisque quis tristique magna. Aenean venenatis justo lobortis massa efficitur, ut vehicula ex eleifend. Curabitur ornare, quam ut blandit pretium, augue mauris commodo erat, a aliquam odio neque sed mi. Proin nec erat justo. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce tempor efficitur tortor, sit amet elementum leo ornare nec. Proin sodales velit sed lorem elementum, a varius dui ullamcorper. Donec laoreet molestie turpis, quis rhoncus sapien faucibus ut. In sagittis accumsan arcu pulvinar imperdiet. Duis eleifend dolor eu purus laoreet mattis. Fusce sed metus risus.\n\nDonec eget lorem cursus, pellentesque ipsum in, volutpat mi. Proin ultrices, erat sed fringilla fermentum, massa odio pulvinar tellus, non pulvinar quam urna vitae massa. Vivamus convallis sollicitudin placerat. Suspendisse vitae sollicitudin lorem. Pellentesque vehicula augue id pharetra ultricies. Aenean id mi finibus, molestie urna vitae, convallis eros. Quisque mollis enim vitae odio tincidunt, et ullamcorper diam dictum. Fusce feugiat neque eu dapibus malesuada. Cras condimentum vestibulum diam. Duis aliquam, ex interdum molestie commodo, diam justo ullamcorper purus, facilisis consectetur lorem justo eu sem. Nulla in augue non dui dignissim accumsan. ", "Sonnez #001 si la porte est fermée", "Gymnase Saint-Henri", "Badminton - Jeudi le 2 mars" },
                    { 2, new DateTime(2023, 3, 10, 4, 56, 9, 313, DateTimeKind.Utc).AddTicks(5912), new DateTime(2023, 3, 4, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 15, 30, 0, 0, DateTimeKind.Unspecified), "Venez jouer avec nous ! Vivamus elementum ultrices ligula nec efficitur. Quisque dictum accumsan euismod. Praesent risus neque, elementum ut nunc non, lobortis efficitur ligula. Proin egestas bibendum libero quis tempor. Etiam iaculis sem sed tortor viverra tempus. Nulla luctus congue enim, sit amet viverra nulla viverra nec. Nam nec ipsum faucibus, ultricies augue vel, tristique orci. Aenean et nunc vulputate, commodo felis vel, euismod sapien. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vestibulum quis elementum urna, quis rhoncus sem. Cras ac ultrices turpis. Phasellus id dolor non erat pretium imperdiet id nec elit.\r\n\r\nCras feugiat tellus quis arcu egestas, sed mollis enim congue. Nulla convallis mollis pellentesque. Curabitur feugiat eros at metus ornare, et cursus ex pharetra. Etiam fermentum, orci vitae commodo volutpat, dolor eros facilisis libero, a elementum magna ante eget sapien. Vivamus eu urna non lorem aliquam fringilla in id sapien. Cras blandit ex in urna interdum, sed fermentum massa lobortis. Maecenas accumsan pulvinar purus quis faucibus. Curabitur leo neque, pharetra eu nunc in, bibendum cursus lectus. Donec fringilla eget odio non pellentesque. Nam eget venenatis sapien, non fringilla lacus. Donec blandit ornare nulla, id porta libero porta eget. Sed ultricies tincidunt sapien. ", "Accéder au gymnase via la porte à droite sur la rue Morin", "Gymnase Verdun", "Soccer" },
                    { 3, new DateTime(2023, 3, 10, 4, 56, 9, 313, DateTimeKind.Utc).AddTicks(5920), new DateTime(2023, 3, 6, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 9, 30, 0, 0, DateTimeKind.Unspecified), "Venez jouer avec nous !", "Dans la salle secrète derrière le mur de livres", "Bibliothèque Verdun", "Tournoi d'échecs" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "username1@gmail.com", "password1", "username1" },
                    { 2, "username2@gmail.com", "password2", "username2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
