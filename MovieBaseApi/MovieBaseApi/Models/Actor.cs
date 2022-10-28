namespace MovieBaseApi.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Nationality { get; set; }
        public int ActorRatingId { get; set; }
        public int MovieId { get; set; }
        public IEnumerable<ActorRating>? ActorRatings { get; }
        public IEnumerable<ActorMovie>? ActorMovie { get; set; }

    }

}
