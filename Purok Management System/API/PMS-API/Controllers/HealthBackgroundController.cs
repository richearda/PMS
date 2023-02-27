using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.HealthBackground;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class HealthBackgroundController : ControllerBase
    {
        #region Fields
        private readonly IHealthBackgroundService _healthBackgroundService;
        #endregion
        #region Constructor
        public HealthBackgroundController(IHealthBackgroundService healthBackgroundService)
        {
            _healthBackgroundService = healthBackgroundService;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetHealthBackground(int id)
        {
            var result = await _healthBackgroundService.GetHealthBackgroundAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateHealthBackground(CreateHealthBackgroundDto healthBackground)
        {
            var result = await _healthBackgroundService.CreateHealthBackgroundAsync(healthBackground);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateHealthBackground([FromBody] HealthBackground healthBackground)
        {
            var result = await _healthBackgroundService.UpdateHealthBackgroundAsync(healthBackground);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteHealthBackground(int id)
        {
            var result = await _healthBackgroundService.DeleteHealthBackgroundAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllHealthBackground()
        {
            var result = await _healthBackgroundService.GetAllHealthBackgroundsAsync();
            return Ok(result);
        }
        #endregion
    }
}
