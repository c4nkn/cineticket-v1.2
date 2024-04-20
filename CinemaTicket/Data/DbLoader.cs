using CinemaTicket.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Data
{
    public class DbLoader
    {
        public static void Load(AppDbContext context)
        {
            context.Database.EnsureCreated();

            var defaultMovies = new List<Movie>()
            {
                new Movie {
                    Title = "Godzilla x Kong: The New Empire",
                    Thumbnail = "..\\..\\Images\\Movie1.jpg",
                    Duration = 115, Genre = "Action, Sci-fi", ImdbRating = 6.5 },
                new Movie {
                    Title = "Dune: Part Two",
                    Thumbnail = "..\\..\\Images\\DunePartTwo.jpg",
                    Duration = 166, Genre = "Action, Adventure, Drama", ImdbRating = 8.8 },
                new Movie {
                    Title = "Ghostbusters: Frozen Empire",
                    Thumbnail = "..\\..\\Images\\GhostbustersFrozenEmpire.jpg",
                    Duration = 117, Genre = "Adventure, Comedy, Fantasy", ImdbRating = 6.4 },
                new Movie {
                    Title = "American Fiction",
                    Thumbnail = "..\\..\\Images\\AmericanFiction.jpg",
                    Duration = 117, Genre = "Comedy, Drama", ImdbRating = 7.6 },
            };

            context.Movies.AddRange(defaultMovies);
            context.SaveChanges();

            var defaultHalls = new List<Hall>
            {
                new Hall { Name = "Hall 1", TotalSeats = 56, ReservedSeats = "A2" },
                new Hall { Name = "Hall 2", TotalSeats = 56, ReservedSeats = "A1, A2" }
            };

            context.Halls.AddRange(defaultHalls);
            context.SaveChanges();

            var movie1 = context.Movies.FirstOrDefault(m => m.Title == "Godzilla x Kong: The New Empire");
            var movie2 = context.Movies.FirstOrDefault(m => m.Title == "Dune: Part Two");
            var hall1 = context.Halls.FirstOrDefault(h => h.Name == "Hall 1");
            var hall2 = context.Halls.FirstOrDefault(h => h.Name == "Hall 2");

            if (movie1 == null || movie2 == null || hall1 == null || hall2 == null)
            {
                throw new InvalidOperationException("Movies or halls are not found in the database.");
            }

            var defaultSessions = new List<Session>()
            {
                new Session {
                    Date = new DateTime(2024, 4, 15, 13, 0, 0),
                    Features = "3D, Subtitled",
                    Duration = 160,
                    AssignedMovieId = movie1.Id,
                    AssignedHallId = hall1.Id
                },
                new Session {
                    Date = new DateTime(2024, 4, 15, 16, 0, 0),
                    Features = "3D, Dubbing",
                    Duration = 160,
                    AssignedMovieId = movie2.Id,
                    AssignedHallId = hall2.Id
                }
            };

            context.Sessions.AddRange(defaultSessions);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding sessions: {ex.Message}");
            }
        }

    }
}
