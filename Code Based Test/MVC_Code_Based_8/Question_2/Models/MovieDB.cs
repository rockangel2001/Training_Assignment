using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Question_2.Models
{
    public class MovieDB : DbContext
    {
        public MovieDB() : base("MoviesDB")

        {

        }
        public DbSet<Movie> Movie { get; set; }
    }
}