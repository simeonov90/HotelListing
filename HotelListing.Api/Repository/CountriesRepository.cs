using HotelListing.Api.Contracts;
using HotelListing.Api.Data;
using HotelListing.Api.Data.Models;

namespace HotelListing.Api.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(HotelListingDbContext context) 
            : base(context)
        {
        }
    }
}
