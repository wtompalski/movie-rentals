using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentals.Model
{
    [ComplexType]
    public class Rating
    {
        [Required]
        public int Value { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }
    }
}
