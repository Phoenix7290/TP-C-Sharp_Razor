using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TP3_Razor.Models;

namespace TP3_Razor.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.CountryName)
                   .HasMaxLength(100)
                   .HasColumnName("Name");

            builder.Property(c => c.CountryCode)
                   .HasMaxLength(2)
                   .HasColumnName("Code");

            builder.HasData(
                new Country { Id = 1, CountryName = "Brazil", CountryCode = "BR" },
                new Country { Id = 2, CountryName = "Portugal", CountryCode = "PT" }
            );
        }
    }
}
