using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MovieRentals.Entities;
using MovieRentals.Model;

namespace MovieRentals.Mappers
{
    public static class Mapper
    {
        public static MovieTraceDto MapToTrace(Movie movie)
        {
            return new MovieTraceDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre
            };
        }

        public static MovieDto Map(Movie movie)
        {
            return new MovieDto
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
