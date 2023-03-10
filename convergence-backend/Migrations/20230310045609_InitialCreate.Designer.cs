﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using convergence_backend.Data;

#nullable disable

namespace convergence_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230310045609_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("convergence_backend.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "username1@gmail.com",
                            Password = "password1",
                            Username = "username1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "username2@gmail.com",
                            Password = "password2",
                            Username = "username2"
                        });
                });

            modelBuilder.Entity("convergence_backend.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateTimeCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeEnd")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeStart")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("LocationDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTimeCreated = new DateTime(2023, 3, 10, 4, 56, 9, 313, DateTimeKind.Utc).AddTicks(5896),
                            DateTimeEnd = new DateTime(2023, 3, 2, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            DateTimeStart = new DateTime(2023, 3, 2, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            DateTimeUpdated = new DateTime(2023, 3, 10, 4, 56, 9, 313, DateTimeKind.Utc).AddTicks(5899),
                            Description = "Venez jouer avec nous ! \n\nLorem ipsum dolor sit amet, consectetur adipiscing elit. In non dapibus leo. Nunc feugiat dapibus ipsum quis pretium. Quisque non ultricies arcu, non auctor nisi. Phasellus faucibus eros a ante blandit, ut dapibus ex blandit. Quisque quis tristique magna. Aenean venenatis justo lobortis massa efficitur, ut vehicula ex eleifend. Curabitur ornare, quam ut blandit pretium, augue mauris commodo erat, a aliquam odio neque sed mi. Proin nec erat justo. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce tempor efficitur tortor, sit amet elementum leo ornare nec. Proin sodales velit sed lorem elementum, a varius dui ullamcorper. Donec laoreet molestie turpis, quis rhoncus sapien faucibus ut. In sagittis accumsan arcu pulvinar imperdiet. Duis eleifend dolor eu purus laoreet mattis. Fusce sed metus risus.\n\nDonec eget lorem cursus, pellentesque ipsum in, volutpat mi. Proin ultrices, erat sed fringilla fermentum, massa odio pulvinar tellus, non pulvinar quam urna vitae massa. Vivamus convallis sollicitudin placerat. Suspendisse vitae sollicitudin lorem. Pellentesque vehicula augue id pharetra ultricies. Aenean id mi finibus, molestie urna vitae, convallis eros. Quisque mollis enim vitae odio tincidunt, et ullamcorper diam dictum. Fusce feugiat neque eu dapibus malesuada. Cras condimentum vestibulum diam. Duis aliquam, ex interdum molestie commodo, diam justo ullamcorper purus, facilisis consectetur lorem justo eu sem. Nulla in augue non dui dignissim accumsan. ",
                            LocationDetail = "Sonnez #001 si la porte est fermée",
                            LocationName = "Gymnase Saint-Henri",
                            Title = "Badminton - Jeudi le 2 mars"
                        },
                        new
                        {
                            Id = 2,
                            DateTimeCreated = new DateTime(2023, 3, 10, 4, 56, 9, 313, DateTimeKind.Utc).AddTicks(5912),
                            DateTimeEnd = new DateTime(2023, 3, 4, 17, 30, 0, 0, DateTimeKind.Unspecified),
                            DateTimeStart = new DateTime(2023, 3, 4, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            DateTimeUpdated = new DateTime(2023, 3, 10, 4, 56, 9, 313, DateTimeKind.Utc).AddTicks(5913),
                            Description = "Venez jouer avec nous ! Vivamus elementum ultrices ligula nec efficitur. Quisque dictum accumsan euismod. Praesent risus neque, elementum ut nunc non, lobortis efficitur ligula. Proin egestas bibendum libero quis tempor. Etiam iaculis sem sed tortor viverra tempus. Nulla luctus congue enim, sit amet viverra nulla viverra nec. Nam nec ipsum faucibus, ultricies augue vel, tristique orci. Aenean et nunc vulputate, commodo felis vel, euismod sapien. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vestibulum quis elementum urna, quis rhoncus sem. Cras ac ultrices turpis. Phasellus id dolor non erat pretium imperdiet id nec elit.\r\n\r\nCras feugiat tellus quis arcu egestas, sed mollis enim congue. Nulla convallis mollis pellentesque. Curabitur feugiat eros at metus ornare, et cursus ex pharetra. Etiam fermentum, orci vitae commodo volutpat, dolor eros facilisis libero, a elementum magna ante eget sapien. Vivamus eu urna non lorem aliquam fringilla in id sapien. Cras blandit ex in urna interdum, sed fermentum massa lobortis. Maecenas accumsan pulvinar purus quis faucibus. Curabitur leo neque, pharetra eu nunc in, bibendum cursus lectus. Donec fringilla eget odio non pellentesque. Nam eget venenatis sapien, non fringilla lacus. Donec blandit ornare nulla, id porta libero porta eget. Sed ultricies tincidunt sapien. ",
                            LocationDetail = "Accéder au gymnase via la porte à droite sur la rue Morin",
                            LocationName = "Gymnase Verdun",
                            Title = "Soccer"
                        },
                        new
                        {
                            Id = 3,
                            DateTimeCreated = new DateTime(2023, 3, 10, 4, 56, 9, 313, DateTimeKind.Utc).AddTicks(5920),
                            DateTimeEnd = new DateTime(2023, 3, 6, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            DateTimeStart = new DateTime(2023, 3, 6, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            DateTimeUpdated = new DateTime(2023, 3, 10, 4, 56, 9, 313, DateTimeKind.Utc).AddTicks(5920),
                            Description = "Venez jouer avec nous !",
                            LocationDetail = "Dans la salle secrète derrière le mur de livres",
                            LocationName = "Bibliothèque Verdun",
                            Title = "Tournoi d'échecs"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}