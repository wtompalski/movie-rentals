using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieRentals.Store;
using MovieRentals.Model;
using MovieRentalsODataService.Store;
using Microsoft.EntityFrameworkCore;

namespace MovieRentals.Controllers
{
    /// <summary>
    /// Movie controller for managing movies.
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
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

        /// <summary>
        /// Gets all movies movies.
        /// </summary>
        /// <returns>List of all movies in database.</returns>
        /// <remarks>
        /// Movies contain all information regarding actors and ratings.
        /// </remarks>
        [HttpGet(Name = "GetMovies")]
        public IActionResult Get()
        {
            return Ok(db.Movies.Include(x => x.Cast));
        }

        /// <summary>
        /// Get specific movie.
        /// </summary>
        /// <param name="id">Id of the movie to get.</param>
        /// <returns>Specific movie from the database.</returns>
        /// <remarks>Movie contains all information regarding actors and ratings.</remarks>
        /// <response code="200">Returns requested movie.</response>
        /// <response code="202">Returns information request is being processed yet.</response>
        /// <response code="204">Movie with given id not found.</response>
        /// <response code="401">Authorization failed.</response>
        /// <response code="500">Database could not be reached.</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(202)]
        [ProducesResponseType(204)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        [HttpGet("{id}", Name = "GetMovie")]
        public IActionResult Get(int id)
        {
            return Ok(db.Movies.FirstOrDefault(m => m.Id == id));
        }

        /// <summary>
        /// Creates new movie.
        /// </summary>
        /// <param name="movie">Movie to add to the database.</param>
        /// <returns>Result of create action.</returns>
        /// <response code="201">Returns the newly created movie</response>
        /// <response code="400">Bad argument received</response>     
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Post([FromBody]Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
            return CreatedAtRoute("GetMovie", new { id = movie.Id }, movie);
        }

        /// <summary>
        /// Deletes movie from database.
        /// </summary>
        /// <param name="id">Id of the movie to delete.</param>
        /// <returns>Result of delete action.</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var m = db.Movies.FirstOrDefault(c => c.Id == id);
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
