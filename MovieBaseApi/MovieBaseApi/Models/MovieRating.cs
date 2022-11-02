namespace MovieBaseApi.Models
{
    public class MovieRating
    {
        public int MovieRatingId { get; set; }
        public int RatingValue { get; set; }
        public DateTime RatingDate { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public Movie? Movie { get; set; }
    }
}
