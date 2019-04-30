using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspVideoRental.Models
{
    using System.ComponentModel.DataAnnotations;

    //   [RMID] bigint NOT NULL
    //, [MovieIDFK]
    //    int NULL
    //, [CustIDFK] int NULL
    //, [DateRented] datetime NULL
    //, [DateReturned] datetime NULL
    //, CONSTRAINT[FK_RentedMovies_0_0] FOREIGN KEY([MovieIDFK]) REFERENCES[Movies] ([MovieID]) ON DELETE NO ACTION ON UPDATE NO ACTION
    //, CONSTRAINT[FK_RentedMovies_1_0] FOREIGN KEY([CustIDFK]) REFERENCES[Customer] ([CustID]) ON DELETE NO ACTION ON UPDATE NO ACTION



    public class RentedMovies
    {
        [Key]
        public int RMID { get; set; }
        public int MovieIDFK { get; set; }
        public int CustIDFK { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime DateReturned { get; set; }


    }
}
