using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRentals.Store;
using MovieRentals.Entities;
using MovieRentals.Model;
using MovieRentals.Mappers;
using Microsoft.AspNet.OData;
using MovieRentalsODataService.Store;

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
            return Ok(db.Movies);
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
