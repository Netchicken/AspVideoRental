using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspVideoRental.Models
{
    using System.ComponentModel.DataAnnotations;

    //  [CustID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
    //, [FirstName] nvarchar(255) NULL COLLATE NOCASE
    //, [LastName] nvarchar(255) NULL COLLATE NOCASE
    //, [Address] nvarchar(255) NULL COLLATE NOCASE
    //, [Phone] nvarchar(255) NULL COLLATE NOCASE

    public class Customer
    {
        [Key]
        public int CustID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
