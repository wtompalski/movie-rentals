using Microsoft.EntityFrameworkCore;
using MovieRentals.Entities;
using MovieRentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalsODataService.Store
{
    public class MovieStoreContext : DbContext
    {
        public MovieStoreContext(DbContextOptions<MovieStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasMany(c => c.Ratings).WithOne();
            modelBuilder.Entity<Movie>().HasMany(c => c.Cast).WithOne();
        }
    }
}
