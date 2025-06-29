using System;
using System.Collections.Generic;
using System.Linq;
using MovieApi.Models;

namespace MovieApi.Services;

public class MovieServices
{
    private readonly List<Movie> _movies;

    public MovieServices()
    {
        _movies = new List<Movie>
        {
            new Movie
            {
                Id = "tt0472181",
                Title = "Madagascar",
                OriginalTitle = "Madagascar",
                Year = 2005,
                Genres = new List<string> { "Animation", "Adventure", "Comedy", "Family" },
                DurationMinutes = 86,
                Rating = 6.9,
                AgeRating = "PG",
                Synopsis = "A group of animals from a New York zoo end up in the wild of Madagascar.",
                Directors = new List<string> { "Eric Darnell", "Tom McGrath" },
                Writers = new List<string> { "Mark Burton", "Billy Frolick", "Eric Darnell", "Tom McGrath" },
                Cast = new List<CastMember>
                {
                    new() { Name = "Ben Stiller", Character = "Alex (voice)" },
                    new() { Name = "Chris Rock", Character = "Marty (voice)" }
                },
                PosterUrl = "...",
                BackdropUrl = "...",
                TrailerUrl = "...",
                OfficialSite = "...",
                Languages = new List<string> { "English" },
                Countries = new List<string> { "USA" },
                ReleaseDate = new DateTime(2005, 5, 27),
                BoxOffice = new BoxOffice { Budget = 75000000, GrossUSA = 193595521, GrossWorldwide = 542063846 },
                Awards = new List<Award>(),
                Reviews = new List<Review>(),
                SimilarMovies = new List<SimilarMovie>(),
                Tags = new List<string> { "animals", "zoo" },
                StreamingProviders = new List<StreamingProvider>(),
                IsTrending = true,
                UserRating = null,
                LastUpdated = DateTime.UtcNow
            },
            new Movie
            {
                Id = "tt1234567",
                Title = "Aventura Espacial",
                OriginalTitle = "Space Adventure",
                Year = 2025,
                Genres = new List<string> { "Sci-Fi", "Adventure" },
                DurationMinutes = 120,
                Rating = 8.5,
                AgeRating = "12",
                Synopsis = "Uma missão intergaláctica emocionante.",
                Directors = new List<string> { "Lucas Terra" },
                Writers = new List<string> { "Lucas Terra" },
                Cast = new List<CastMember>
                {
                    new() { Name = "João Silva", Character = "Capitão Zeta" }
                },
                PosterUrl = "...",
                BackdropUrl = "...",
                TrailerUrl = "...",
                OfficialSite = "...",
                Languages = new List<string> { "Português" },
                Countries = new List<string> { "Brasil" },
                ReleaseDate = new DateTime(2025, 6, 15),
                BoxOffice = new BoxOffice { Budget = 10000000, GrossUSA = 0, GrossWorldwide = 0 },
                Awards = new List<Award>(),
                Reviews = new List<Review>(),
                SimilarMovies = new List<SimilarMovie>(),
                Tags = new List<string>(),
                StreamingProviders = new List<StreamingProvider>(),
                IsTrending = false,
                UserRating = null,
                LastUpdated = DateTime.UtcNow
            }
        };
    }

    public IEnumerable<Movie> GetAllMovies()
    {
        return _movies;
    }

    public IEnumerable<Movie> GetMoviesByGenre(string genre)
    {
        return _movies.Where(m => m.Genres != null && m.Genres.Any(g => g.Equals(genre, StringComparison.OrdinalIgnoreCase)));
    }

    public IEnumerable<Movie> GetReleasesByYear(int year)
    {
        return _movies.Where(m => m.ReleaseDate.Year == year);
    }
}
