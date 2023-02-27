using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS_API.DTO.AppUser;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        //Incomplete
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUserDto userDto)
        {
            if (!await _accountService.IsUsernameExist(userDto.Username)) return Unauthorized("Invalid username.");
            var result = await _accountService.Login(userDto);
            if (result is null) return Unauthorized("Incorrect login details!");
            return Ok(result);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterUserDto userDto)
        {
            if (await _accountService.IsUsernameExist(userDto.Username)) return BadRequest("Username already exist.");
            var result = await _accountService.Register(userDto);
            return Ok(result);
        }

        [HttpGet("ValidateUsername")]
        public async Task<IActionResult> IsUsernameExist(string username)
        {
            var result = await _accountService.IsUsernameExist(username);
            return Ok(result);
        }
    }
}
