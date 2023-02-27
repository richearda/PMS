using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.Barangay;
using PMS_API.Extensions;
using PMS_API.Helpers;
using PMS_API.Models;
using PMS_API.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BarangayController : ControllerBase
    {
        #region Fields
        private readonly IBarangayService _barangayService;
        #endregion
        #region Constructor
        public BarangayController(IBarangayService barangayService)
        {
            _barangayService = barangayService;
        }
        #endregion
        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetBarangay(int id)
        {
            var result = await _barangayService.GetBarangayAsync(id);
            return Ok(result);
        }


        [HttpPost("Create")]
        public async Task<IActionResult> CreateBarangay([FromBody] CreateBarangayDto barangay)
        {
            var result = await _barangayService.CreateBarangayAsync(barangay);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateBarangay([FromBody] CreateBarangayDto barangay)
        {
            var result = await _barangayService.UpdateBarangayAsync(barangay);
            return Ok(result);
        }

   
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteBarangay(int id)
        {
            var result = await _barangayService.DeleteBarangayAsync(id);
            return Ok(result);
        }


        [HttpGet("List")]
        public async Task<IActionResult> GetAllBarangay()
        {
            var result = await _barangayService.GetAllBarangayAsync();
            return Ok(result);
        }
        [HttpGet("List/PurokSitios")]
        public async Task<IActionResult> GetAllPurokSitioByBarangayIdAsync(int Id)
        {
            var result = await _barangayService.GetAllPurokSitioByBarangayIdAsync(Id);
            return Ok(result);
        }

        [HttpGet("List/ByCityMunicipality")]

        public async Task<IActionResult> GetAllBarangaysWithParamsAsync([FromQuery] BarangayParams barangayParams)
        {
            var barangays = await _barangayService.GetAllBarangayWithParamsAsync(barangayParams);
            Response.AddPaginationHeader(barangays.CurrentPage, barangays.PageSize, barangays.TotalCount, barangays.TotalPages);
            return Ok(barangays);
        }

        #endregion

    }
}
