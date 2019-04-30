using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspVideoRental.Models
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.ComponentModel.DataAnnotations;

    //SELECT [MovieID]
    //    ,[Title]
    //    ,[Year]
    //    ,[Rating]
    //    ,[Plot]
    //    ,[Genre]
    //    ,[Copies]
    //FROM [Movies];

    public class Movies
    {
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Plot { get; set; }
        public string Genre { get; set; }
        public string Copies { get; set; }


    }
}
