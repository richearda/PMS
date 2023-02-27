using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.CityMunicipality;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CityMunicipalityController : ControllerBase
    {
        #region Fields
        private readonly ICityMunicipalityService _cityMunicipalityService;
        #endregion
        #region Constructor
        public CityMunicipalityController(ICityMunicipalityService cityMunicipalityService)
        {
            _cityMunicipalityService = cityMunicipalityService;
        }
        #endregion
        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetCityMunicipality(int id)
        {
            var result = await _cityMunicipalityService.GetCityMunicipalityAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateCityMunicipality([FromBody] CreateCityMunicipalityDto cityMunicipality)
        {
            var result = await _cityMunicipalityService.CreateCityMunicipalityAsync(cityMunicipality);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateCityMunicipality([FromBody] CityMunicipality cityMunicipality)
        {
            var result = await _cityMunicipalityService.UpdateCityMunicipalityAsync(cityMunicipality);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteCityMunicipality(int id)
        {
            var result = await _cityMunicipalityService.DeleteCityMunicipalityAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllCityMunicipality()
        {
            var result = await _cityMunicipalityService.GetAllCityMunicipalityAsync();
            return Ok(result);
        }

        [HttpGet("List/Barangays")]
        public async Task<IActionResult> GetAllBarangayByCityMunicipalityIdAsync(int Id)
        {
            var result = await _cityMunicipalityService.GetAllBarangayByCityMunicipalityIdAsync(Id);
            return Ok(result);
        }
        #endregion
    }
}
