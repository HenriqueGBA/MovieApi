using System;
using System.Collections.Generic;
using MovieApi.Models;
using System.Linq;

namespace MovieApi.Services;

public class MovieServices
{
    public IEnumerable<Movie> GetAllMovies()
    {
        var movie = new Movie
        {
            Id = "tt0472181",
            Title = "Madagascar",
            OriginalTitle = "Madagascar",
            Year = 2005,
            Genres = new List<string> { "Animation", "Adventure", "Comedy", "Family" },
            DurationMinutes = 86,
            Rating = 6.9,
            AgeRating = "PG",
            Synopsis = "A group of animals who have spent all their life in a New York zoo end up in the jungles of Madagascar, and must adjust to living in the wild.",
            Directors = new List<string> { "Eric Darnell", "Tom McGrath" },
            Writers = new List<string> { "Mark Burton", "Billy Frolick", "Eric Darnell", "Tom McGrath" },
            Cast = new List<CastMember>
            {
                new() { Name = "Ben Stiller", Character = "Alex (voice)" },
                new() { Name = "Chris Rock", Character = "Marty (voice)" },
                new() { Name = "David Schwimmer", Character = "Melman (voice)" },
                new() { Name = "Jada Pinkett Smith", Character = "Gloria (voice)" }
            },
            PosterUrl = "https://m.media-amazon.com/images/I/81c5tQQt+uL._AC_SY679_.jpg",
            BackdropUrl = "https://m.media-amazon.com/images/M/madagascar_backdrop.jpg",
            TrailerUrl = "https://www.youtube.com/watch?v=hdcTmpvDO0I",
            OfficialSite = "https://www.dreamworks.com/madagascar",
            Languages = new List<string> { "English", "Spanish", "French" },
            Countries = new List<string> { "USA" },
            ReleaseDate = new DateTime(2005, 5, 27),
            BoxOffice = new BoxOffice
            {
                Budget = 75000000,
                GrossUSA = 193595521,
                GrossWorldwide = 542063846
            },
            Awards = new List<Award>
            {
                new() { Name = "Annie Awards", Category = "Best Animated Feature", Year = 2006, Result = "Nominated" }
            },
            Reviews = new List<Review>
            {
                new() { Author = "Roger Ebert", Source = "Chicago Sun-Times", Rating = 3, MaxRating = 4, Excerpt = "A bright and witty animated comedy." },
                new() { Author = "IGN", Source = "IGN.com", Rating = 7, MaxRating = 10, Excerpt = "Fun for kids and entertaining for adults." }
            },
            SimilarMovies = new List<SimilarMovie>
            {
                new() { Id = "tt0351283", Title = "Madagascar: Escape 2 Africa" },
                new() { Id = "tt1277953", Title = "Madagascar 3: Europe's Most Wanted" }
            },
            Tags = new List<string> { "animals", "zoo", "jungle", "friendship", "adventure" },
            StreamingProviders = new List<StreamingProvider>
            {
                new() { Name = "Netflix", Url = "https://www.netflix.com/title/70021636" },
                new() { Name = "Amazon Prime Video", Url = "https://www.primevideo.com/detail/0K1T17FAZH68HPGZJ37L8M6YX7" }
            },
            IsTrending = true,
            UserRating = null,
            LastUpdated = DateTime.UtcNow
        };

        return new List<Movie> { movie };
    }

    public IEnumerable<Movie> GetMoviesByGenre(string genre)
    {
        var allMovies = GetAllMovies();
        var filteredMovies = allMovies.Where(m => m.Genres.Any(g => g.Equals(genre, StringComparison.OrdinalIgnoreCase)));

        return filteredMovies;
    }
}
