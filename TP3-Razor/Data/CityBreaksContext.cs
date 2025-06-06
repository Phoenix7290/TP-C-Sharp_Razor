using TP3_Razor.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using Property = TP3_Razor.Models.Property;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TP3_Razor.Data.Configurations;
using PropertyConfiguration = TP3_Razor.Data.Configurations.PropertyConfiguration;

namespace TP3_Razor.Data
{
    public class CityBreaksContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Property> Properties { get; set; }

        public CityBreaksContext(DbContextOptions<CityBreaksContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new PropertyConfiguration());
        }
    }
}
