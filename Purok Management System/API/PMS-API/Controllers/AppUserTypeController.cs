using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.AppUserType;
using PMS_API.DTO.Barangay;
using PMS_API.Extensions;
using PMS_API.Helpers;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AppUserTypeController : ControllerBase
    {
        private readonly IAppUserTypeService _appUserTypeService;
        public AppUserTypeController(IAppUserTypeService appUserTypeServive)
        {
            _appUserTypeService = appUserTypeServive;
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAppUserType(int id)
        {
            var result = await _appUserTypeService.GetAppUserTypeAsync(id);
            return Ok(result);
        }


        [HttpPost("Create")]
        public async Task<IActionResult> CreateAppUserType([FromBody] CreateAppUserTypeDto appUserTypeDto)
        {
            var result = await _appUserTypeService.CreateAppUserTypeAsync(appUserTypeDto);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAppUserType([FromBody] GetAppUserTypeDto appUserTypeDto)
        {
            var result = await _appUserTypeService.UpdateAppUserTypeAsync(appUserTypeDto);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAppUserType(int id)
        {
            var result = await _appUserTypeService.DeleteAppUserTypeAsync(id);
            return Ok(result);
        }


        [HttpGet("List")]
        public async Task<IActionResult> GetAppUserTypes()
        {
            var result = await _appUserTypeService.GetAppUserTypesAsync();
            return Ok(result);
        }
       
    }
}
