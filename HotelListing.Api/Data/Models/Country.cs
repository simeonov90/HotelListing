

using System.Text.Json.Serialization;

namespace HotelListing.Api.Data.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        [JsonIgnore]
        public IList<Hotel> Hotels { get; set; }
    }
}