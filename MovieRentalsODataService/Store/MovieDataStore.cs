using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MovieRentals.Entities;
using MovieRentals.Model;

namespace MovieRentals.Store
{
    public class MovieDataStore
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Year = 1994,
                Genre = "Drama",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Ratings =
                {
                    new Rating { Value = 10 },
                    new Rating { Value = 9, Comment = "Movie of all time" }
                },
                Cast =
                {
                    new Actor { Id = 1, FirstName = "Tim", LastName = "Robins", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1958, 10, 16)) },
                    new Actor { Id = 2, FirstName = "Morgan", LastName = "Freeman", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1937, 6, 1)) }
                }
            },
            new Movie
            {
                Id = 2,
                Title = "The Godfather",
                Year = 1972,
                Genre = "Crime, Drama",
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                Ratings =
                {
                    new Rating { Value = 10 },
                    new Rating { Value = 9, Comment = "Movie of all time" }
                },
                Cast =
                {
                    new Actor { Id = 3, FirstName = "Marlon", LastName = "Brando", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1924, 4, 3)) },
                    new Actor { Id = 2, FirstName = "Al", LastName = "Pacino", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1940, 4, 25)) }
                }
            },
            new Movie
            {
                Id = 3,
                Title = "The Dark Knight",
                Year = 2008,
                Genre = "Action, Crime, Drama",
                Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                Ratings =
                {
                    new Rating { Value = 10 },
                    new Rating { Value = 9, Comment = "Movie of all time" }
                },
                Cast =
                {
                    new Actor { Id = 3, FirstName = "Christian", LastName = "Bale", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1974, 1, 30)) },
                    new Actor { Id = 2, FirstName = "Heath", LastName = "Ledger", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1979, 4, 4)) }
                }
            },
            new Movie
            {
                Id = 4,
                Title = "12 Angry Men",
                Year = 1957,
                Genre = "Crime, Drama",
                Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                Ratings =
                {
                    new Rating { Value = 10 },
                    new Rating { Value = 9, Comment = "Movie of all time" }
                },
                Cast =
                {
                    new Actor { Id = 3, FirstName = "Martin", LastName = "Balsam", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1919, 11, 4)) },
                    new Actor { Id = 2, FirstName = "John", LastName = "Fielder", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1925, 2, 3)) }
                }
            },
            new Movie
            {
                Id = 5,
                Title = "Pulp Fiction",
                Year = 1994,
                Genre = "Crime, Drama",
                Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                Ratings =
                {
                    new Rating { Value = 10 },
                    new Rating { Value = 9, Comment = "Movie of all time" }
                },
                Cast =
                {
                    new Actor { Id = 3, FirstName = "John", LastName = "Travolta", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1954, 2, 18)) },
                    new Actor { Id = 2, FirstName = "John", LastName = "Fielder", Gender = Gender.Male, DateOfBirth = new DateTimeOffset(new DateTime(1970, 4, 29)) }
                }

            }
        };
    }
}
