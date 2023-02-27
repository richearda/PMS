using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.PurokSitio;
using PMS_API.Extensions;
using PMS_API.Helpers;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PurokSitioController : ControllerBase
    {
        #region Fields
        private readonly IPurokSitioService _purokSitioService;
        #endregion
        #region Constructor
        public PurokSitioController(IPurokSitioService purokSitioService)
        {
            _purokSitioService = purokSitioService;
        }
        #endregion
        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetPurokSitio(int id)
        {
            var result = await _purokSitioService.GetPurokSitioAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreatePurokSitio([FromBody] CreatePurokSitioDto purokSitio)
        {
            var result = await _purokSitioService.CreatePurokSitioAsync(purokSitio);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdatePurokSitio([FromBody] PurokSitio purokSitio)
        {
            var result = await _purokSitioService.UpdatePurokSitioAsync(purokSitio);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeletePurokSitio(int id)
        {
            var result = await _purokSitioService.DeletePurokSitioAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllPurokSitio()
        {
            var result = await _purokSitioService.GetAllPurokSitioAsync();
            return Ok(result);
        }

        [HttpGet("List/ByBarangay")]
        public async Task<IActionResult> GetAllPurokSitioWithParams([FromQuery] PurokSitioParams purokSitioParams)
        {
            var purokSitios = await _purokSitioService.GetAllPurokSitioWithParamsAsync(purokSitioParams);
            Response.AddPaginationHeader(purokSitios.CurrentPage, purokSitios.PageSize, purokSitios.TotalCount, purokSitios.TotalPages);
            return Ok(purokSitios);
        }
        #endregion
    }
}
