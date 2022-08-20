using MovieApp.Enums;
using MovieApp.Models.Entities;

namespace MovieApp.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }    
        protected string _password { get; set; }
        public Genre FavoriteGenre { get; set; }
        public List<Movie> FavoriteMovies { get; set; }

        public User(int id, string firstName, string lastName, string userName, string password, Genre favoriteGenre, List<Movie> favoriteMovies)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            _password = password;
            FavoriteGenre = favoriteGenre;
            FavoriteMovies = favoriteMovies;
        }
    }
}
