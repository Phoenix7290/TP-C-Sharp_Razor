using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TP3_Razor.Models;

namespace TP3_Razor.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(p => p.Name)
                   .HasMaxLength(200)
                   .HasColumnName("PropertyName");

            builder.Property(p => p.DeletedAt)
               .HasColumnName("DeletedAt")
               .IsRequired(false); 

            builder.HasData(
                new Property { Id = 1, Name = "Hotel Central SP", PricePerNight = 250.00m, CityId = 1 },
                new Property { Id = 2, Name = "Pousada Lisboa", PricePerNight = 150.00m, CityId = 2 }
            );
        }
    }
}
