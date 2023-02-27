using PMS_API.DTO.AppUserType;
using PMS_API.DTO.Gender;
using PMS_API.DTO.PersonDtos;

namespace PMS_API.DTO.AppUser
{
    public class RegisterUserDto
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public CreatePersonDto PersonDto { get; set; }
        public int AppUserTypeId { get; set; }
        
    }
}
