namespace MovieBaseApi.Models
{
    public class ActorDTO
    {
        public int ActorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Nationality { get; set; }
        //public IEnumerable<Movie> GetMovies()
        //{

        //}
    }
}
