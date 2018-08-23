using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRentalsWeb.Models;

namespace MovieRentalsWeb.Controllers
{
    public class MovieController : Controller
    {
        [Route("{id}")]
        public async Task<ActionResult> Index(int id)
        {
            var client = new MoviesRentalWebAPIClient();
            var movie = await client.GetMovie(id);

            var viewModel = new MovieViewModel
            {
                Movie = movie
            };

            return View(viewModel);
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
 