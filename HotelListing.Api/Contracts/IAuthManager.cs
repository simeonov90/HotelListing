using HotelListing.Api.Models.HotelUser;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.Api.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(CreateHotelUserDto createHotelUserDto);
    }
}
