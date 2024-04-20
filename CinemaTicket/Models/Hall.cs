using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalSeats { get; set; }


        public ICollection<Session> Sessions { get; set; }
    }
}
