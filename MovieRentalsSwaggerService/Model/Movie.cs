using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentals.Model
{
    /// <summary>
    /// Represents movie in the database.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Id of the movie.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Title of the movie.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        /// <summary>
        /// Year of the movie.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Description of the movie.
        /// </summary>
        [StringLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Genre of the movie.
        /// </summary>
        [Required]
        public string Genre { get; set; }

        /// <summary>
        /// Cast of the movie.
        /// </summary>
        public ICollection<Actor> Cast { get; } = new List<Actor>();

        /// <summary>
        /// Ratings of the movie.
        /// </summary>
        public Rating Rating { get; set; }
    }
}
