using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.BloodType;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BloodTypeController : ControllerBase
    {
        #region Fields
        private readonly IBloodTypeService _bloodTypeService;
        #endregion
        #region Constructor
        public BloodTypeController(IBloodTypeService bloodTypeService)
        {
            _bloodTypeService = bloodTypeService;
        }
        #endregion
        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetBloodType(int id)
        {
            var result = await _bloodTypeService.GetBloodTypeAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateBloodType([FromBody] CreateBloodTypeDto bloodType)
        {
            var result = await _bloodTypeService.CreateBloodTypeAsync(bloodType);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateBloodType([FromBody] BloodType bloodType)
        {
            var result = await _bloodTypeService.UpdateBloodTypeAsync(bloodType);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteBloodType(int id)
        {
            var result = await _bloodTypeService.DeleteBloodTypeAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllBloodType()
        {
            var result = await _bloodTypeService.GetAllBloodTypeAsync();
            return Ok(result);
        }
        #endregion
    }
}
