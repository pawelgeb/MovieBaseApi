namespace MovieBaseApi.Models
{
    public class ScreenWriter
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Nationality { get; set; }
        public IEnumerable<Movie>? Movies { get; set; }

    }
}
