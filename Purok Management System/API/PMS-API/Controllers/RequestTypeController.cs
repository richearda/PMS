using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.RequestType;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class RequestTypeController : ControllerBase
    {
        #region Fields
        private readonly IRequestTypeService _requestTypeService;
        #endregion
        #region Constructor
        public RequestTypeController(IRequestTypeService RequestTypeService)
        {
            _requestTypeService = RequestTypeService;
        }
        #endregion
        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetRequestType(int id)
        {
            var result = await _requestTypeService.GetRequestTypeAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateRequestType([FromBody] CreateRequestTypeDto requestType)
        {
            var result = await _requestTypeService.CreateRequestTypeAsync(requestType);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateRequestType([FromBody] RequestType requestType)
        {
            var result = await _requestTypeService.UpdateRequestTypeAsync(requestType);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteRequestType(int id)
        {
            var result = await _requestTypeService.DeleteRequestTypeAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllRequestType()
        {
            var result = await _requestTypeService.GetAllRequestTypesAsync();
            return Ok(result);
        }
        #endregion
    }
}
