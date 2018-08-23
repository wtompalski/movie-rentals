using MovieRentalsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace MovieRentalsWeb
{
    public class MoviesRentalWebAPIClient
    {
        private static readonly HttpClient client = new HttpClient(new HttpClientHandler()
        {
            UseDefaultCredentials = true
        });

        public async Task<List<MovieTraceDto>> GetMovies()
        {
            var serializer = new DataContractJsonSerializer(typeof(IEnumerable<MovieTraceDto>));

            var streamTask = client.GetStreamAsync("http://localhost:50529/api/movies");
            var movies = serializer.ReadObject(await streamTask) as IEnumerable<MovieTraceDto>;

            return movies.ToList();
        }

        public async Task<CollectionResourceWrapperDto<MovieTraceDto>> GetMovieCollection()
        {
            var serializer = new DataContractJsonSerializer(typeof(CollectionResourceWrapperDto<MovieTraceDto>));

            var streamTask = client.GetStreamAsync("http://localhost:50529/api/movies");
            var movies = serializer.ReadObject(await streamTask) as CollectionResourceWrapperDto<MovieTraceDto>;

            return movies;
        }

        public async Task<MovieDto> GetMovie(string url)
        {
            var serializer = new DataContractJsonSerializer(typeof(MovieDto));

            var streamTask = client.GetStreamAsync(url);
            var movie = serializer.ReadObject(await streamTask) as MovieDto;

            return movie;
        }

        public async Task<HttpResponseMessage> Post(string url)
        {
            var res = await client.PostAsync(url, null);
            return res;
        }

    }
}
