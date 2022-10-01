﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieList.Models;

namespace MovieList.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieList.Models.Genre", b =>
                {
                    b.Property<string>("GenreID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreID = "A",
                            Name = "Action"
                        },
                        new
                        {
                            GenreID = "C",
                            Name = "Comedy"
                        },
                        new
                        {
                            GenreID = "D",
                            Name = "Drama"
                        },
                        new
                        {
                            GenreID = "H",
                            Name = "Horror"
                        },
                        new
                        {
                            GenreID = "M",
                            Name = "Musical"
                        },
                        new
                        {
                            GenreID = "R",
                            Name = "RomCom"
                        },
                        new
                        {
                            GenreID = "S",
                            Name = "SciFi"
                        });
                });

            modelBuilder.Entity("MovieList.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("GenreID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            GenreID = "D",
                            Name = "Casablanca",
                            Rating = 5,
                            Year = 1942
                        },
                        new
                        {
                            MovieId = 2,
                            GenreID = "A",
                            Name = "Wonder Woman",
                            Rating = 3,
                            Year = 2017
                        },
                        new
                        {
                            MovieId = 3,
                            GenreID = "R",
                            Name = "Moonstruck",
                            Rating = 5,
                            Year = 1988
                        });
                });

            modelBuilder.Entity("MovieList.Models.Movie", b =>
                {
                    b.HasOne("MovieList.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
