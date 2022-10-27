namespace MovieBaseApi.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Nationality { get; set; }
        public int ActorRatingId { get; set; }
        public IEnumerable<ActorRating>? ActorRatings { get;}
    }
}
