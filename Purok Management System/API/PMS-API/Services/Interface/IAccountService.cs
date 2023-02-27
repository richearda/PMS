using PMS_API.DTO.AppUser;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IAccountService
    {
        /// <summary>
        /// Register a user and store login details to database.
        /// </summary>
        /// <param name="userDto">The login details of user.</param>
        /// <returns></returns>
        Task<int> Register(RegisterUserDto userDto);
        /// <summary>
        /// Authenticate user.
        /// </summary>
        /// <param name="userDto">The login details provided by user.</param>
        /// <returns></returns>
        Task<UserDto> Login(LoginUserDto userDto);
        /// <summary>
        /// Check wether username already exist in the database.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns></returns>
        Task<bool> IsUsernameExist(string username);
    }
}
