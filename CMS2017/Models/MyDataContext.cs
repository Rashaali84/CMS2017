using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CMS2017.Models;

namespace CMS2017.Models
{
    public class MyDataContext : DbContext
    {
        public MyDataContext() : base("Data Source=.;Initial Catalog=CMS;trusted_connection=true ;User Id=sa;Password=123;")
        {

        }

        // public DbSet<Cusotmer> Cusotmers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; }

    }
}