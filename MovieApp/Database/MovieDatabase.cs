using MovieApp.Entities;

namespace MovieApp.Database
{
    public static class MovieDatabase
    {
        public static List<Director> DIRECTORS = new List<Director>()
        {
            new Director(1,"Stanley","Kubrick"),
            new Director(2,"Steven","Spielberg"),
            new Director(3,"Martin","Scorsese"),
            new Director(4,"Quentin","Tarantino"),
            new Director(5,"Federico","Fellini"),
            new Director(6,"David","Lynch"),
            new Director(7,"Roman","Polanski"),
            new Director(8,"Denis","Villeneuve"),
            new Director(9,"Christopher","Nolan")
        };

        public static List<Movie> MOVIES = new List<Movie>()
        {
            new Movie (1,"Tenet","Armed with only one word, Tenet, and fighting for the survival of the entire world, a Protagonist journeys through a twilight world of international espionage on a mission that will unfold in something beyond real time",new DateTime(2020,9,3),Enums.Genre.Action,DIRECTORS.Last()),
            new Movie (2,"Interstellar","A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",new DateTime(2020,9,3),Enums.Genre.Action,DIRECTORS.Last()),
            new Movie (3,"Memento","A man with short-term memory loss attempts to track down his wife's murderer.",new DateTime(2020,9,3),Enums.Genre.Action,DIRECTORS.First())
        };

        public static List<User> USERS = new List<User>()
        {
            new User(1,"Cvetan","Josheski","cvetanj","12348765",Enums.Genre.Action,new List<Movie> {MOVIES.Last()}),
            new User(2,"Stefan","Stefanoski","stefans","12348765",Enums.Genre.Romance,new List<Movie> {MOVIES.First()}),
            new User(3,"David","Davidoski","davidd","12348765", Enums.Genre.Action,MOVIES),
            new User(4,"Pece","Peceski","pecep","12348765",Enums.Genre.Drama,MOVIES)
        };
    }
}
