using HotelListing.Api.Models.Country;

namespace HotelListing.Api.Services.Countries
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetCountries();
        Task<CountryDto> GetCountryById(int id);
        Task UpdateCountry(UpdateCountryDto countryDto);
        Task<CountryDto> CreateCountry(CreateCountryDto countryDto);
        Task DeleteCountry(int id);
        Task<bool> CountryExists(int id);
    }
}
