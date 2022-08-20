using MovieApp.Entities;

namespace MovieApp.DTOs
{
    public class CreateUserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public List<Movie> MovieList { get; set; } = new List<Movie>();
       
    }
}
