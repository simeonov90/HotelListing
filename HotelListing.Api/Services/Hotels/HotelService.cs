using AutoMapper;
using HotelListing.Api.Contracts;
using HotelListing.Api.Data.Models;
using HotelListing.Api.Models.Hotel;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Services.Hotels
{
    public class HotelService : IHotelService
    {
        private readonly IHotelsRepository repository;
        private readonly IMapper mapper;

        public HotelService(IHotelsRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<HotelDto> CreateHotel(CreateHotelDto hotelDto)
        {
            var country = mapper.Map<Hotel>(hotelDto);
            await repository.AddAsync(country);
            return mapper.Map<HotelDto>(country);
        }

        public async Task DeleteHotel(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<HotelDto> GetHotelById(int id)
        {
            var hotel = await repository.GetAsync(id);
            return mapper.Map<HotelDto>(hotel);
        }

        public async Task<IEnumerable<HotelDto>> GetHotels()
        {
            var hotels = await repository.GetAllAsync();
            return mapper.Map<IEnumerable<HotelDto>>(hotels);
        }

        public async Task<IEnumerable<HotelDto>> GetAllHotels()
        {
            var hotels = await repository.GetAll().Include(c => c.Country).ToListAsync();
            return mapper.Map<IEnumerable<HotelDto>>(hotels);
        }

        public async Task<bool> HotelExists(int id)
        {
            return await repository.Exists(id);
        }

        public async Task UpdateHotel(UpdateHotelDto hotelDto)
        {
            var hotel = await repository.GetAsync(hotelDto.Id);
            await repository.UpdateAsync(hotel);
        }
    }
}
