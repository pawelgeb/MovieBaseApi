namespace MovieBaseApi.Models
{
    public class ActorRating
    {
        public int Id { get; set; }
        public int RatingValue { get; set; }
        public DateTime RatingDate { get; set; }
        public int IdUser { get; set; }
        public int IdActor { get; set; }
        public User? User { get; set; }
        public Actor? Actor { get; set; }

    }
}
