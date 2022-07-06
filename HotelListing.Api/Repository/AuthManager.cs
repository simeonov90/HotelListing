using AutoMapper;
using HotelListing.Api.Contracts;
using HotelListing.Api.Data.Models;
using HotelListing.Api.Models.HotelUser;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.Api.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper mapper;
        private readonly UserManager<HotelUser> userManager;

        public AuthManager(IMapper mapper, UserManager<HotelUser> userManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
        }
        public async Task<IEnumerable<IdentityError>> Register(CreateHotelUserDto createHotelUserDto)
        {
            var user = mapper.Map<HotelUser>(createHotelUserDto);
            user.UserName = createHotelUserDto.Email;
            var result = await userManager.CreateAsync(user, createHotelUserDto.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }
    }
}
