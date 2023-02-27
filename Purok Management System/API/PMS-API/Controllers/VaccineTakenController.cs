using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.VaccineTaken;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class VaccineTakenController : ControllerBase
    {
        #region Fields
        private readonly IVaccineTakenService _vaccineTakenService;
        #endregion
        #region Constructor
        public VaccineTakenController(IVaccineTakenService vaccineTakenService)
        {
            _vaccineTakenService = vaccineTakenService;
        }
        #endregion
        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetVaccineTaken(int id)
        {
            var result = await _vaccineTakenService.GetVaccineTakenAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateVaccineTaken([FromBody] CreateVaccineTakenDto vaccineTaken)
        {
            var result = await _vaccineTakenService.CreateVaccineTakenAsync(vaccineTaken);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateVaccineTaken([FromBody] VaccineTaken vaccineTaken)
        {
            var result = await _vaccineTakenService.UpdateVaccineTakenAsync(vaccineTaken);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteVaccineTaken(int id)
        {
            var result = await _vaccineTakenService.DeleteVaccineTakenAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllVaccineTaken()
        {
            var result = await _vaccineTakenService.GetAllVaccineTakenAsync();
            return Ok(result);
        }
        #endregion
    }
}
