using AutoMapper;
using HotelListing.Api.Contracts;
using HotelListing.Api.Data.Models;
using HotelListing.Api.Models.Country;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Services.Countries
{
    public class CountryService : ICountryService
    {
        private readonly ICountriesRepository repository;
        private readonly IMapper mapper;

        public CountryService(ICountriesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<bool> CountryExists(int id)
        {
            return await repository.Exists(id);
        }

        public async Task<CountryDto> CreateCountry(CreateCountryDto countryDto)
        {
            var country = mapper.Map<Country>(countryDto);
            await repository.AddAsync(country);
            return mapper.Map<CountryDto>(country);
        }

        public async Task DeleteCountry(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CountryDto>> GetCountries()
        {
            var countries = await repository.GetAllAsync();

            return mapper.Map<IEnumerable<CountryDto>>(countries);
        }

        public async Task<CountryDto> GetCountryById(int id)
        {
            var country = await repository.GetAll().Where(c => c.Id == id).Include(h => h.Hotels).FirstOrDefaultAsync();
            return mapper.Map<CountryDto>(country);
        }

        public async Task UpdateCountry(UpdateCountryDto countryDto)
        {
            var country = mapper.Map<Country>(countryDto);
            await repository.UpdateAsync(country);
        }
    }
}
