using MovieApp.Enums;
using MovieApp.Models.Entities;

namespace MovieApp.Entities
{
    public class Movie : BaseEntity
    {      
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
        public Genre Genre { get; set; }
        public Director Director { get; set; }

        public Movie()
        {

        }
    }
}
