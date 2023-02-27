using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.CivilStatus;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CivilStatusController : ControllerBase
    {
        private readonly ICivilStatusService _civilStatusService;

        public CivilStatusController(ICivilStatusService civilStatusService)
        {
            _civilStatusService = civilStatusService;
        }
        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetCivilStatus(int id)
        {
            var result = await _civilStatusService.GetCivilStatusAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateCivilStatus([FromBody] CreateCivilStatusDto civilStatus)
        {
            var result = await _civilStatusService.CreateCivilStatusAsync(civilStatus);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateCivilStatus([FromBody] CivilStatus civilStatus)
        {
            var result = await _civilStatusService.UpdateCivilStatusAsync(civilStatus);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteCivilStatus(int id)
        {
            var result = await _civilStatusService.DeleteCivilStatusAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllCivilStatus()
        {
            var result = await _civilStatusService.GetAllCivilStatusAsync();
            return Ok(result);
        }
        #endregion
    }
}
