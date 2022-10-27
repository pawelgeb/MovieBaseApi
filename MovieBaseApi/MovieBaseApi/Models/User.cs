namespace MovieBaseApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime RegisterDate { get; set; }
        public int MovieRatingId { get; set; }
        public int ActorRatingId { get; set; }
        public IEnumerable<ActorRating>? ActorRatings { get; set; }
        public IEnumerable<MovieRating>? MovieRatings { get; set; } 

    }
}
