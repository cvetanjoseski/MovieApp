using MovieApp.Enums;

namespace MovieApp.DTOs
{
    public class CreateMovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public Genre Genre { get; set; }
    }
}
