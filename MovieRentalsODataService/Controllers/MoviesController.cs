using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieRentals.Store;
using MovieRentals.Model;
using Microsoft.AspNet.OData;
using MovieRentalsODataService.Store;
using Microsoft.EntityFrameworkCore;

namespace MovieRentals.Controllers
{
    public class MoviesController : ODataController
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

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(db.Movies.Include(x => x.Cast));
        }

        [EnableQuery]
        public IActionResult Get(int id)
        {
            return Ok(db.Movies.FirstOrDefault(m => m.Id == id));
        }

        [EnableQuery]
        public IActionResult Post([FromBody]Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
            return Created(movie);
        }

        [EnableQuery]
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
