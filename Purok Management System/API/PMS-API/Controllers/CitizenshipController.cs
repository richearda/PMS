using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.Citizenship;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CitizenshipController : ControllerBase
    {
        #region Fields
        private readonly ICitizenshipService _citizenshipService;
        #endregion
        #region Constructor
        public CitizenshipController(ICitizenshipService citizenshipService)
        {
            _citizenshipService = citizenshipService;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetCitizenship(int id)
        {
            var result = await _citizenshipService.GetCitizenshipAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateCitizenship([FromBody] CreateCitizenshipDto citizenship)
        {
            var result = await _citizenshipService.CreateCitizenshipAsync(citizenship);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateCitizenship([FromBody] Citizenship citizenship)
        {
            var result = await _citizenshipService.UpdateCitizenshipAsync(citizenship);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteCitizenship(int id)
        {
            var result = await _citizenshipService.DeleteCitizenshipAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllCitizenship()
        {
            var result = await _citizenshipService.GetAllCitizenshipAsync();
            return Ok(result);  
        }
        #endregion
    }
}
