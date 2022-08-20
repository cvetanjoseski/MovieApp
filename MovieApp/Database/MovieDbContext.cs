using Microsoft.EntityFrameworkCore;
using MovieApp.Entities;

namespace MovieApp.Database
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<User> Users { get; set; }

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieDbContext).Assembly);
            modelBuilder.Entity<Movie>();
        }
    }
}
