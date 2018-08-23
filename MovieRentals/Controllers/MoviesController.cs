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
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly MoviesRepository moviesRepository = new MoviesRepository();

        [HttpGet]
        public IEnumerable<MovieTraceDto> Get()
        {
            return this.moviesRepository.GetMovies().Select(NotSoAutoMapper.MapToTrace);
        }

        [HttpGet("{id}")]
        public MovieDto Get(int id)
        {
            var movie = this.moviesRepository.GetMovie(id);
            return NotSoAutoMapper.Map(movie);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
