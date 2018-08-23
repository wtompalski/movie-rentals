using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRentals.Store;
using MovieRentals.Entities;
using MovieRentals.Model;
using MovieRentals.Mappers;

namespace MovieRentals.Controllers
{
    [Route("api/returnMovie")]
    public class ReturnController : Controller
    {
        private readonly MoviesRepository moviesRepository = new MoviesRepository();

        public ReturnController()
        {
        }

        [HttpPost("{id}", Name = "ReturnMovie")]
        public IActionResult Post(int id)
        {
            var movie = this.moviesRepository.GetMovie(id);
            movie.RentedBy = null;

            return AcceptedAtRoute("GetMovie", new { id = movie.Id });
        }
    }
}
