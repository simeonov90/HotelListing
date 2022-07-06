using HotelListing.Api.Models.Hotel;

namespace HotelListing.Api.Services.Hotels
{
    public interface IHotelService
    {
        Task<IEnumerable<HotelDto>> GetHotels();
        Task<HotelDto> GetHotelById(int id);
        Task UpdateHotel(UpdateHotelDto hotelDto);
        Task<HotelDto> CreateHotel(CreateHotelDto hotelDto);
        Task DeleteHotel(int id);
        Task<IEnumerable<HotelDto>> GetAllHotels();
        Task<bool> HotelExists(int id);
    }
}
