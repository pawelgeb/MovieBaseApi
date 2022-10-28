namespace MovieBaseApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime RegisterDate { get; set; }
        public ActorRating? ActorRating { get; set; }
        public MovieRating? MovieRating { get; set; }
    }
}
