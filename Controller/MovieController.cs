using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;
using MovieApi.Services;

namespace MovieApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly MovieServices _movieService;

        public MovieController(MovieServices movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("AllMovies")]
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

        [HttpGet("release/{year}")]

        public IActionResult GetByReleaseYear(int year)
        {
            var movies = _movieService.GetReleasesByYear(year);
            return Ok(new { movies });
        }

    }
}