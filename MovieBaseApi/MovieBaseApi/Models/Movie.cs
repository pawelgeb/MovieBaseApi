namespace MovieBaseApi.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public DateTime RelaseDate { get; set; }
        public string? Category { get; set; }
        public int DirectorId { get; set; }
        public int ScreenWriterId { get; set; }
        public IEnumerable<MovieRating>? MovieRating { get; set; }
        public Director? Director { get; set; }
        public ScreenWriter? ScreenWriter { get; set; }
        public IEnumerable<ActorMovie>? ActorMovie { get; set; }
    }
}
