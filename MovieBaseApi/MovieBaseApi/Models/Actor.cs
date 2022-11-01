namespace MovieBaseApi.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Nationality { get; set; }
        public int MovieId { get; set; }
        public IEnumerable<ActorRating>? ActorRating { get; set; }
        public IEnumerable<ActorMovie>? ActorMovie { get; set; }

    }

}
