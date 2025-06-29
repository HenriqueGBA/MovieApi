using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;
using MovieApi.Services;

namespace MovieApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieServices _movieService;

        public MoviesController(MovieServices movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var movies = _movieService.GetAllMovies();
            return Ok(new { movies });
        }

        [HttpGet("genre/{genre}")]
        public IActionResult GetByGenre(String genre)
        {
            var movies = _movieService.GetMoviesByGenre(genre);
            return Ok(new { movies });
        }
    }
}