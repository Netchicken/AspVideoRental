using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspVideoRental.Models
{
    public class RentalsWithNames
    {
        public int RMID { get; set; }
        public string Movie { get; set; }
        public string Cust { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime DateReturned { get; set; }

    }
}
