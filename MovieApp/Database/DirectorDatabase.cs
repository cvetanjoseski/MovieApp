using MovieApp.Entities;

namespace MovieApp.Database
{
    public static class DirectorDatabase
    {
        public static List<Director> DIRECTORS = new List<Director>()
        {
            new Director(1,"Stanley","Kubrick"),
            new Director(2,"Steven","Spielberg"),
            new Director(3,"Martin","Scorsese") ,
            new Director(4,"Quentin","Tarantino"),
            new Director(5,"Federico","Fellini"),
            new Director(6,"David","Lynch"),
            new Director(7,"Roman","Polanski"),
            new Director(8,"Denis","Villeneuve"),
            new Director(9,"Christopher","Nolan")
        };
    }
}
