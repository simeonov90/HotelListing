using Microsoft.AspNetCore.Identity;

namespace HotelListing.Api.Data.Models
{
    public class HotelUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
