using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Features { get; set; }
        public int Duration { get; set; }

        public int AssignedMovieId { get; set; }
        public Movie AssignedMovie { get; set; }

        public int AssignedHallId { get; set; }
        public Hall AssignedHall { get; set; }
    }
}
