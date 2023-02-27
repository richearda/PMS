using PMS_API.DTO.AppUserType;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IAppUserTypeService
    {
        Task<GetAppUserTypeDto> GetAppUserTypeAsync(int appUserTypeId);
        Task<IEnumerable<GetAppUserTypeDto>> GetAppUserTypesAsync();
        Task<CreateAppUserTypeDto> CreateAppUserTypeAsync(CreateAppUserTypeDto appUserType);
        Task<GetAppUserTypeDto> UpdateAppUserTypeAsync(GetAppUserTypeDto appUserType);
        Task<AppUserType> DeleteAppUserTypeAsync(int appUserTypeId);
    }
}
