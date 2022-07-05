using HotelListing.Api.Models.Country;

namespace HotelListing.Api.Models.Hotel
{
    public class HotelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public int CountryId { get; set; }
        public CountryDto Country { get; set; }
    }
}
