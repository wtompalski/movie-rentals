using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieRentals.Store;
using MovieRentals.Model;
using MovieRentalsODataService.Store;
using Microsoft.EntityFrameworkCore;

namespace MovieRentals.Controllers
{
    [Route("api/movies")]
    public class MoviesController : Controller
    {
        private readonly MovieStoreContext db;

        public MoviesController(MovieStoreContext context)
        {
            db = context;
            if (context.Movies.Count() == 0)
            {
                foreach (var movie in MovieDataStore.Movies)
                {
                    context.Movies.Add(movie);

                    foreach (var actor in movie.Cast)
                    {
                        context.Actors.Add(actor);
                    }
                    
                }
                context.SaveChanges();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Movies.Include(x => x.Cast));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(db.Movies.FirstOrDefault(m => m.Id == id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
            return Created($"\\api\\movies\\{movie.Id}", movie);
        }

        [HttpPost]
        public IActionResult Delete([FromBody]int key)
        {
            var m = db.Movies.FirstOrDefault(c => c.Id == key);
            if (m == null)
            {
                return NotFound();
            }

            db.Movies.Remove(m);
            db.SaveChanges();
            return Ok();
        }
    }
}
