using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListing.Api.Models.Country;
using HotelListing.Api.Services.Countries;

namespace HotelListing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService countryService;

        public CountriesController(ICountryService countryService)
        {
            this.countryService = countryService;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryDto>>> GetCountries()
        {
            var countries = await countryService.GetCountries();

            if (countries is null) return NotFound();

            return Ok(countries);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryDto>> GetCountry(int id)
        {
            if (!await countryService.CountryExists(id)) return NotFound();

            return await countryService.GetCountryById(id);
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, UpdateCountryDto country)
        {
            if (id != country.Id) return BadRequest();

            if (!await countryService.CountryExists(id)) return NotFound();

            try
            {
                await countryService.UpdateCountry(country);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await countryService.CountryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CountryDto>> PostCountry(CreateCountryDto countryDto)
        {
            var dto = await countryService.CreateCountry(countryDto);
            return CreatedAtAction("GetCountry", new { id = dto.Id }, dto);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            if (!await countryService.CountryExists(id)) return NotFound();

            await countryService.DeleteCountry(id);
            return NoContent();
        }
    }
}
