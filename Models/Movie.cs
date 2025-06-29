using System;
using System.Collections.Generic;

namespace MovieApi.Models
{
    public class Movie
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? OriginalTitle { get; set; }
        public int Year { get; set; }
        public List<string>? Genres { get; set; }
        public int DurationMinutes { get; set; }
        public double Rating { get; set; }
        public string? AgeRating { get; set; }
        public string? Synopsis { get; set; }
        public List<string>? Directors { get; set; }
        public List<string>? Writers { get; set; }
        public List<CastMember>? Cast { get; set; }
        public string? PosterUrl { get; set; }
        public string? BackdropUrl { get; set; }
        public string? TrailerUrl { get; set; }
        public string? OfficialSite { get; set; }
        public List<string>? Languages { get; set; }
        public List<string>? Countries { get; set; }
        public DateTime ReleaseDate { get; set; }
        public BoxOffice? BoxOffice { get; set; }
        public List<Award>? Awards { get; set; }
        public List<Review>? Reviews { get; set; }
        public List<SimilarMovie>? SimilarMovies { get; set; }
        public List<string>? Tags { get; set; }
        public List<StreamingProvider>? StreamingProviders { get; set; }
        public bool IsTrending { get; set; }
        public double? UserRating { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public class CastMember
    {
        public string? Name { get; set; }
        public string? Character { get; set; }
    }

    public class BoxOffice
    {
        public long Budget { get; set; }
        public long GrossUSA { get; set; }
        public long GrossWorldwide { get; set; }
    }

    public class Award
    {
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int Year { get; set; }
        public string? Result { get; set; }
    }

    public class Review
    {
        public string? Author { get; set; }
        public string? Source { get; set; }
        public double Rating { get; set; }
        public double MaxRating { get; set; }
        public string? Excerpt { get; set; }
    }

    public class SimilarMovie
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
    }

    public class StreamingProvider
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}
