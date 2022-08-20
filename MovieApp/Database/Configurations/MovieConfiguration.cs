using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Entities;

namespace MovieApp.Database.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(x => x.Id).HasName("Id");
            builder.Property(x => x.Title).HasColumnType("nvarchar(255)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("nvarchar(1000)").IsRequired();
            builder.Property(x => x.Genre).HasColumnType("int").IsRequired();
            builder.Property(x => x.Year).IsRequired();
        }
    }
}
