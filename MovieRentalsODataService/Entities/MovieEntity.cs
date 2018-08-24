using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentals.Entities
{
    public class MovieEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }

        public string Genre { get; set; }

        public string RentedBy { get; set; }
    }
}
