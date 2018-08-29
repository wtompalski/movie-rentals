using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentals.Model
{
    /// <summary>
    /// Represents movie rating.
    /// </summary>
    [ComplexType]
    public class Rating
    {
        /// <summary>
        /// Rating value.
        /// </summary>
        [Required]
        public int Value { get; set; }

        /// <summary>
        /// Rating comment.
        /// </summary>
        [StringLength(100)]
        public string Comment { get; set; }
    }
}
