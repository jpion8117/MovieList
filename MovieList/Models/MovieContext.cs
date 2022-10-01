using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                    new Genre
                    {
                        GenreID = "A",
                        Name = "Action"
                    },
                    new Genre
                    {
                        GenreID = "C",
                        Name = "Comedy"
                    },
                    new Genre
                    {
                        GenreID = "D",
                        Name = "Drama"
                    },
                    new Genre
                    {
                        GenreID = "H",
                        Name = "Horror"
                    },
                    new Genre
                    {
                        GenreID = "M",
                        Name = "Musical"
                    },
                    new Genre
                    {
                        GenreID = "R",
                        Name = "RomCom"
                    },
                    new Genre
                    {
                        GenreID = "S",
                        Name = "SciFi"
                    }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        MovieId = 1,
                        Name = "Casablanca",
                        Year = 1942,
                        Rating = 5,
                        GenreID = "D"
                    },
                    new Movie
                    {
                        MovieId = 2,
                        Name = "Wonder Woman",
                        Year = 2017,
                        Rating = 3,
                        GenreID = "A"
                    },
                    new Movie
                    {
                        MovieId = 3,
                        Name = "Moonstruck",
                        Year = 1988,
                        Rating = 5,
                        GenreID = "R"
                    }
                );
        }
    }
}
