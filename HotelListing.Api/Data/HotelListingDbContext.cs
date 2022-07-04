using HotelListing.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahams",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 1,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
            );
        }
    }
}
