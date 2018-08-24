using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MovieRentals.Entities;
using MovieRentals.Model;

namespace MovieRentals.Mappers
{
    public static class NotSoAutoMapper
    {
        public static Movie Map(MovieEntity movie)
        {
            return new Movie
            {
                Id = movie.Id,
                Title = movie.Title,
                Year = movie.Year,
                Genre = movie.Genre,
                Description = movie.Description,
            };
        }
    }
}
