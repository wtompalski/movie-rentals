using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieRentals.Entities;
using MovieRentals.Model;
using MovieRentalsODataService.Logger;
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
            modelBuilder.Entity<Movie>(e =>
            {
                e.HasMany(c => c.Cast).WithOne();
                e.OwnsOne(e1 => e1.Rating);
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            LoggerFactory loggerFactory = new LoggerFactory();
            loggerFactory.AddConsole();
            loggerFactory.AddProvider(new TraceLoggerProvider());
            optionsBuilder.UseLoggerFactory(loggerFactory);

            base.OnConfiguring(optionsBuilder);

        }
    }
}
