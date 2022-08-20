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

        public Movie(int id, string title, string description, DateTime year, Genre genre, Director director)
        {
            Id = id;
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            Director = director;
        }
    }
}
