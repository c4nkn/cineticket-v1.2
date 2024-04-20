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
                new Hall { Name = "Hall 1", TotalSeats = 84 },
                new Hall { Name = "Hall 2", TotalSeats = 84 },
                new Hall { Name = "Hall 3", TotalSeats = 84 },
                new Hall { Name = "Hall 4", TotalSeats = 84 },
                new Hall { Name = "Hall 5", TotalSeats = 84 },
                new Hall { Name = "Hall 6", TotalSeats = 84 }
            };

            context.Halls.AddRange(defaultHalls);
            context.SaveChanges();

            Random random = new Random();

            foreach (var movie in defaultMovies)
            {
                var hallIndex = 0;

                DateTime startDate = DateTime.Now;
                int numberOfDays = 7;
                int intervalBetweenSessionsInMinutes = 90;

                var sessionsToAdd = new List<Session>();

                for (int i = 0; i < numberOfDays; i++)
                {
                    DateTime currentDate = startDate.AddDays(i);
                    DateTime startTime = currentDate.Date.AddHours(13);

                    for (int j = 0; j < 3; j++)
                    {
                        var session = new Session
                        {
                            Date = startTime.AddMinutes(j * intervalBetweenSessionsInMinutes),
                            Features = (movie.Title == "Godzilla x Kong: The New Empire") ? "3D, Subtitled" :
                                       (movie.Title == "Dune: Part Two") ? "2D, Dubbing" :
                                       (movie.Title == "Ghostbusters: Frozen Empire") ? "3D, Subtitled" :
                                       (movie.Title == "American Fiction") ? "2D, Subtitled" : "",
                            Duration = movie.Duration,
                            AssignedMovieId = movie.Id,
                            AssignedHallId = defaultHalls[hallIndex].Id
                        };

                        int totalSeats = defaultHalls[hallIndex].TotalSeats;
                        int luckyNumber = random.Next(totalSeats);

                        var reservedSeatIndexes = new HashSet<int>();

                        while (reservedSeatIndexes.Count < totalSeats && reservedSeatIndexes.Count < luckyNumber)
                        {
                            int row = random.Next(7) + 1;
                            int seatNumber = random.Next(12) + 1;

                            int seatIndex = (row - 1) * 12 + seatNumber;

                            if (!reservedSeatIndexes.Contains(seatIndex))
                            {
                                reservedSeatIndexes.Add(seatIndex);
                            }
                        }

                        List<string> markedSeats = new List<string>();

                        string[] rows = { "A", "B", "C", "D", "E", "F", "G" };

                        foreach (int index in reservedSeatIndexes)
                        {
                            int row = (index - 1) / 12;
                            int seat = (index - 1) % 12 + 1;

                            string seatName = $"{rows[row]}{seat}";

                            markedSeats.Add(seatName);
                        }

                        string markedSeatsString = string.Join(",", markedSeats);
                        session.ReservedSeats = markedSeatsString;

                        sessionsToAdd.Add(session);
                        hallIndex = (hallIndex + 1) % defaultHalls.Count;
                    }
                }

                context.Sessions.AddRange(sessionsToAdd);
            }

            context.SaveChanges();
        }

    }
}
