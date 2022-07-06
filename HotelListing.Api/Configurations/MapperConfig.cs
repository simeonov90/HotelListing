using AutoMapper;
using HotelListing.Api.Data.Models;
using HotelListing.Api.Models.Country;
using HotelListing.Api.Models.Hotel;
using HotelListing.Api.Models.HotelUser;

namespace HotelListing.Api.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CreateHotelDto, Hotel>();
            CreateMap<Hotel, HotelDto>();
            CreateMap<UpdateHotelDto, Hotel>();
            CreateMap<UpdateCountryDto, Country>();
            CreateMap<CreateCountryDto, Country>();
            CreateMap<Country, CountryDto>();
            CreateMap<CreateHotelUserDto, HotelUser>();
        }
    }
}
