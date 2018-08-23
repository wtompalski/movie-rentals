using MovieRentalsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalsWeb.Models
{
    public class MoviesViewModel
    {
        public CollectionResourceWrapperDto<MovieTraceDto> Movies { get; set; }
    }
}
