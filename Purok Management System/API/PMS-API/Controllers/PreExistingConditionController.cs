using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.PreExistingCondition;
using PMS_API.Models;
using PMS_API.Services;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PreExistingConditionController : ControllerBase
    {
        #region Fields
        private readonly IPreExistingConditionService _preExistingConditionService;
        #endregion
        #region Constructor
        public PreExistingConditionController(IPreExistingConditionService preExistingConditionService)
        {
            _preExistingConditionService = preExistingConditionService;
        }
        #endregion
        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetPreExistingCondition(int id)
        {
            var result = await _preExistingConditionService.GetPreExistingConditionAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreatePreExistingCondition([FromBody] CreatePreExistingConditionDto preExistingCondition)
        {
            var result = await _preExistingConditionService.CreatePreExistingConditionAsync(preExistingCondition);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdatePreExistingCondition([FromBody] CreatePreExistingConditionDto preExistingCondition)
        {
            var result = await _preExistingConditionService.UpdatePreExistingConditionAsync(preExistingCondition);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeletePreExistingCondition(int id)
        {
            var result = await _preExistingConditionService.DeletePreExistingConditionAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllPreExistingCondition()
        {
            var result = await _preExistingConditionService.GetAllPreExistingCondtionAsync();
            return Ok(result);
        }
        #endregion
    }
}

