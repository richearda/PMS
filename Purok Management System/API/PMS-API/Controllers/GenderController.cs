using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.Gender;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class GenderController : ControllerBase
    {
        #region Fields
        private readonly IGenderService _genderService;
        #endregion
        #region Constructor
        public GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetGender(int id)
        {
            var result = await _genderService.GetGenderAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateGender(CreateGenderDto gender)
        {
            var result = await _genderService.CreateGenderAsync(gender);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateGender([FromBody] Gender gender)
        {
            var result = await _genderService.UpdateGenderAsync(gender);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteGender(int id)
        {
            var result = await _genderService.DeleteGenderAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllGender()
        {
            var result = await _genderService.GetAllGenderAsync();
            return Ok(result);
        }
        #endregion
    }
}
