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
                    Id = 3,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "JaHotel",
                    Address = "Jamaica Street",
                    Rating = 5,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "BaHotel",
                    Address = "Bahams Street",
                    Rating = 5,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "CaymanHotel",
                    Address = "Cayman Street",
                    Rating = 5,
                    CountryId = 3
                }
            );
        }
    }
}
