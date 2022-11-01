namespace MovieBaseApi.Models
{
    public class ActorRating
    {
        public int ActorRatingId { get; set; }
        public int RatingValue { get; set; }
        public DateTime RatingDate { get; set; }
        public int UserId { get; set; }
        public int ActorId { get; set; }
        public User? User { get; set; }
        public Actor? Actor { get; set; }

    }
}
