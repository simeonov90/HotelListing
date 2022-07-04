﻿namespace HotelListing.Api.Data.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public virtual IList<Country> Countries { get; set; }
    }
}