using System.ComponentModel.DataAnnotations;

namespace HotelListing.Api.Models.HotelUser
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
