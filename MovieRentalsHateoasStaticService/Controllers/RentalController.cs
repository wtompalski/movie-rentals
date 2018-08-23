using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRentals.Store;
using MovieRentals.Entities;
using MovieRentals.Model;
using MovieRentals.Mappers;
using Microsoft.AspNetCore.Authorization;

namespace MovieRentals.Controllers
{
    [Route("api/rentMovie")]
    public class RentalController : Controller
    {
        private readonly MoviesRepository moviesRepository = new MoviesRepository();

        public RentalController()
        {
        }

        [Authorize]
        [HttpPost("{id}", Name = "RentMovie")]
        public IActionResult Post(int id)
        {
            var movie = this.moviesRepository.GetMovie(id);
            movie.RentedBy = this.User.Identity.Name;

            return AcceptedAtRoute("GetMovie", new { id = movie.Id });

        }

        [Authorize]
        [HttpGet("{id}", Name = "RentMovie")]
        public void Get(int id)
        {
            var movie = this.moviesRepository.GetMovie(id);
            movie.RentedBy = this.User.Identity.Name;
        }
    }
}
