using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRentalsWeb.Models;

namespace MovieRentalsWeb.Controllers
{
    public class MoviesController : Controller
    {
        [Route("")]
        public async Task<ActionResult> Index()
        {
            var client = new MoviesRentalWebAPIClient();
            var movies = await client.GetMovieCollection();

            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public async Task<ActionResult> Movie(string url)
        {
            var client = new MoviesRentalWebAPIClient();
            var movie = await client.GetMovie(url);

            var viewModel = new MovieViewModel
            {
                Movie = movie
            };

            return View(viewModel);
        }

        public async Task<ActionResult> RentMovie(string url)
        {
            var client = new MoviesRentalWebAPIClient();

            var response = await client.Post(url);


            return RedirectToAction("Movie", new { url = response.Headers.Location });
        }

        //[Route("")]
        //public ActionResult Index()
        //{

        //    var viewModel = new MoviesViewModel
        //    {
        //        Movies = new List<Model.MovieTraceDto>()
        //        {
        //            new Model.MovieTraceDto
        //            {
        //                Id = 1,
        //                Title = "Abc",
        //                Genre = "Comedy"
        //            }
        //        }
        //    };

        //    return View(viewModel);
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }



        //// GET: Movies/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Movies/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Movies/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Movies/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Movies/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Movies/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Movies/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
 