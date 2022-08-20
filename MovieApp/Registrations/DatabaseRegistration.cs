using MovieApp.Database;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Registrations
{
    public static class DatabaseRegistration
    {
        public static IServiceCollection RegisterDatabase(this IServiceCollection serviceCollection,
                                                          string connectionString)
        {
            serviceCollection.AddDbContext<MovieDbContext>(actions =>
            {
                actions.UseSqlServer(connectionString);
            });
            return serviceCollection;
        }

    }
}
