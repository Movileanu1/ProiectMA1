using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectMA.Models;

namespace ProiectMA.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) :
       base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Publshedcar> PublishedCars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Car>().ToTable("Car"); modelBuilder.Entity<System.Security.Policy.Publisher>().ToTable("Publisher");
            modelBuilder.Entity<Publshedcar>().ToTable("PublishedCar");
            modelBuilder.Entity<Publshedcar>()
            .HasKey(c => new { c.CarID, c.PublisherID });//configureaza cheia primara compusa
        }
    }
}
