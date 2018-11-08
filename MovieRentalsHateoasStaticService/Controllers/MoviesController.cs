using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRentals.Store;
using MovieRentals.Entities;
using MovieRentals.Model;
using MovieRentals.Mappers;
using MovieRentalsHateoasStaticService.Model;

namespace MovieRentals.Controllers
{
    [Route("api/movies")]
    public class MoviesController : Controller
    {
        private readonly MoviesRepository moviesRepository = new MoviesRepository();

        [HttpGet(Name = "GetMovies")]
        public CollectionResourceWrapperDto<MovieTraceDto> Get()
        {
            var movies = this.moviesRepository.GetMovies().Select(Mapper.MapToTrace).Select(AddLinks);

            var wrapper = new CollectionResourceWrapperDto<MovieTraceDto>(movies);

            return AddLinks(wrapper);
        }

        [HttpGet("{id}", Name = "GetMovie")]
        public MovieDto Get(int id)
        {
            var movie = this.moviesRepository.GetMovie(id);
            var result = Mapper.Map(movie);

            return AddLinks(result, movie.RentedBy);
        }

        private MovieDto AddLinks(MovieDto movie, string rentedBy)
        {
            movie.Links.Add(new LinkDto(this.Url.Link("GetMovie", new { id = movie.Id }), "self", "GET"));

            if (rentedBy == null)
            {
                movie.Links.Add(new LinkDto(this.Url.Link("RentMovie", new { id = movie.Id }), "rentMovie", "POST"));
            }
            
            if (rentedBy == this.User.Identity.Name)
            {
                movie.Links.Add(new LinkDto(this.Url.Link("ReturnMovie", new { id = movie.Id }), "returnMovie", "POST"));
            }

            movie.Links.Add(new LinkDto(this.Url.Link("GetMovies", new { }), "index", "GET"));

            return movie;
        }

        private MovieTraceDto AddLinks(MovieTraceDto movie)
        {
            movie.Links.Add(new LinkDto(this.Url.Link("GetMovie", new { id = movie.Id }), "self", "GET"));

            return movie;
        }

        private CollectionResourceWrapperDto<MovieTraceDto> AddLinks(CollectionResourceWrapperDto<MovieTraceDto> movies)
        {
            movies.Links.Add(new LinkDto(this.Url.Link("GetMovies", new { }), "self", "GET"));
            return movies;
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
