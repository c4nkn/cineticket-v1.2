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
        public void Load(DbContext context)
        {
            var defaultMovies = new List<Movie>()
            {
                new Movie {
                    Title = "Godzilla x Kong: The New Empire",
                    Thumbnail = "..\\..\\Assets\\Movie1.jpg",
                    Duration = 115, Genre = "Action, Sci-fi", ImdbRating = 6.5 },
                new Movie {
                    Title = "Dune: Part Two",
                    Thumbnail = "..\\..\\Assets\\DunePartTwo.jpg",
                    Duration = 166, Genre = "Action, Adventure, Drama", ImdbRating = 8.8 },
                new Movie {
                    Title = "Ghostbusters: Frozen Empire",
                    Thumbnail = "..\\..\\Assets\\GhostbustersFrozenEmpire.jpg",
                    Duration = 117, Genre = "Adventure, Comedy, Fantasy", ImdbRating = 6.4 },
                new Movie {
                    Title = "American Fiction",
                    Thumbnail = "..\\..\\Assets\\AmericanFiction.jpg",
                    Duration = 117, Genre = "Comedy, Drama", ImdbRating = 7.6 },
                new Movie {
                    Title = "American Fiction",
                    Thumbnail = "..\\..\\Assets\\AmericanFiction.jpg",
                    Duration = 117, Genre = "Comedy, Drama", ImdbRating = 7.6 },
            };

            var sessionTimes = new List<DateTime>
            {
                new DateTime(2024, 4, 15, 14, 0, 0),
                new DateTime(2024, 4, 15, 17, 0, 0),
                new DateTime(2024, 4, 15, 20, 0, 0)
            };

            var sessionFeatures = new List<string>
            {
                "Standard",
                "2D",
                "3D",
                "Subtitled",
                "Dubbing",
                "IMAX"
            };

            var defaultSessions = new List<Session> {
                new Session { Date = new DateTime(2024, 4, 15, 21, 0, 0), Features="", AssignedMovieId = defaultMovies[0].Id, }
            };

            context.Set<Movie>().AddRange(defaultMovies);
            context.SaveChanges();
        }
    }
}
