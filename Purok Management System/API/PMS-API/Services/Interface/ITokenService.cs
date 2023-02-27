using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
