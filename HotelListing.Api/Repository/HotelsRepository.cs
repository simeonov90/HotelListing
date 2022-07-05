using HotelListing.Api.Contracts;
using HotelListing.Api.Data;
using HotelListing.Api.Data.Models;

namespace HotelListing.Api.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context)
            : base(context)
        {
        }
    }
}
