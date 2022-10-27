namespace MovieBaseApi.Models
{
    public class MovieRating
    {
        public int Id { get; set; }
        public int RatingValue { get; set; }
        public DateTime RatingDate { get; set; }
        public int IdUser { get; set; }
        public User? User { get; set; }

    }
}
