using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string SelectedSeat { get; set; }
        public decimal Price { get; set; }

        public int SelectedMovieId { get; set; }
        public Movie SelectedMovie { get; set; }
        public int SelectedSessionId { get; set; }
        public Session SelectedSession { get; set; }
    }
}
