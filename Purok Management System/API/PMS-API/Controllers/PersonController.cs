using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.PersonDtos;
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
    public class PersonController : ControllerBase
    {
        #region Fields
        private readonly IPersonService _personService;
        #endregion
        #region Constructor
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetPerson(int id)
        {
            var result = await _personService.GetPersonAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreatePerson([FromBody] CreatePersonDto person)
        {
            var result = await _personService.CreatePersonAsync(person);
            return Ok(result);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdatePerson([FromBody] Person person)
        {
            var result = await _personService.UpdatePersonAsync(person);
            return Ok(result);
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            var result = await _personService.DeletePersonAsync(id);
            return Ok(result);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllPersonsAsync([FromQuery] PersonParams userParams)
        {
            var users = await _personService.GetAllPersonsAsync(userParams);
            Response.AddPaginationHeader(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPages);
            return Ok(users);
        }
        #endregion
    }
}
