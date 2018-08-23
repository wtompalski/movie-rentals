using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MovieRentals.Entities;

namespace MovieRentals.Store
{
    public class MoviesRepository
    {
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Year = 1994,
                Genre = "Drama",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
            },
            new Movie
            {
                Id = 2,
                Title = "The Godfather",
                Year = 1972,
                Genre = "Crime, Drama",
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
            },
            new Movie
            {
                Id = 3,
                Title = "The Dark Knight",
                Year = 2008,
                Genre = "Action, Crime, Drama",
                Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice."
            },
            new Movie
            {
                Id = 4,
                Title = "12 Angry Men",
                Year = 1957,
                Genre = "Crime, Drama",
                Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence."
            },
            new Movie
            {
                Id = 5,
                Title = "Pulp Fiction",
                Year = 1994,
                Genre = "Crime, Drama",
                Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption."
            }
        };

        public Movie GetMovie(int id)
        {
            return Movies.FirstOrDefault(movie => movie.Id == id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return Movies;
        }
    }
}
