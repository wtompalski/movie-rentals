using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentals.Model
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Year { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public string Genre { get; set; }

        public ICollection<Actor> Cast { get; } = new List<Actor>();

        public Rating Rating { get; set; }
    }
}
