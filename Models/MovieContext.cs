using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspVideoRental.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public MovieContext()
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<RentedMovies> RentedMovies { get; set; }

        //removed when controllers were created as it throws an error
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = VideoDB.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

    }
}
