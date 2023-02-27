using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.Request;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class RequestController : ControllerBase
    {
        #region Fields
        private readonly IRequestService _requestService;
        #endregion
        #region Constructor
        public RequestController(IRequestService requestService)
        {
            _requestService = requestService;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetRequest(int id)
        {
            var result = await _requestService.GetRequestAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateRequest([FromBody] CreateRequestDto request)
        {
            var result = await _requestService.CreateRequestAsync(request);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateRequest([FromBody] Request request)
        {
            var result = await _requestService.UpdateRequestAsync(request);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteRequest(int id)
        {
            var result = await _requestService.DeleteRequestAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllRequest()
        {
            var result = await _requestService.GetAllRequestsAsync();
            return Ok(result);
        }
        #endregion
    }
}
