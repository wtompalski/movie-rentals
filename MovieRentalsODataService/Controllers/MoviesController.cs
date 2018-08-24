﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRentals.Store;
using MovieRentals.Entities;
using MovieRentals.Model;
using MovieRentals.Mappers;
using Microsoft.AspNet.OData;

namespace MovieRentals.Controllers
{

    public class MoviesController : ODataController
    {
        private readonly MoviesRepository moviesRepository = new MoviesRepository();

 
        [EnableQuery]
        public IEnumerable<MovieDto> Get()
        {
            return this.moviesRepository.GetMovies().Select(NotSoAutoMapper.Map);
        }

        [EnableQuery]
        public MovieDto Get(int id)
        {
            var movie = this.moviesRepository.GetMovie(id);
            return NotSoAutoMapper.Map(movie);
        }
    }
}
