using MovieApp.Models.Entities;

namespace MovieApp.Entities
{
    public class Director : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Movie> Movies { get; set; }

        public Director(int id, string firstName, string lastName)        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;            
        }
    }
}
