using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CinemaTicket.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Thumbnail { get; set; }
        public String Genre { get; set; }
        public int Duration { get; set; }
        public double ImdbRating { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
