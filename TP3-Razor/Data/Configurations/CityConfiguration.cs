using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TP3_Razor.Models;

namespace TP3_Razor.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Name)
                   .HasMaxLength(100)
                   .HasColumnName("CityName");

            builder.HasData(
                new City { Id = 1, Name = "São Paulo", CountryId = 1 },
                new City { Id = 2, Name = "Lisboa", CountryId = 2 }
            );
        }
    }
}
