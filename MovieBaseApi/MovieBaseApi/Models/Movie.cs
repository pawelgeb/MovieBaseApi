namespace MovieBaseApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public DateTime RelaseDate { get; set; }
        public string? Category { get; set; }
        public int RatingId { get; set; }
        public int DirectorId { get; set; }
        public int ScreeWriterId { get; set; }
        public IEnumerable<MovieRating>? MovieRatings { get; set; }
        public Director? Director { get; set; }
        public ScreenWriter? ScreenWriter { get; set; }
        public IEnumerable<Actor>? Actor { get; set; }
        public IEnumerable<ActorMovie>? ActorMovie { get; set; }
    }
}
