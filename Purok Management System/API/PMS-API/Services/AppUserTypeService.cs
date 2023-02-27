using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.AppUserType;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class AppUserTypeService : IAppUserTypeService
    {
        private readonly DatabaseContext _dbContext;
        public AppUserTypeService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateAppUserTypeDto> CreateAppUserTypeAsync(CreateAppUserTypeDto appUserType)
        {
            AppUserType userType = new AppUserType
            {
                AppUserTypeName = appUserType.AppUserTypeName,
                IsActive = appUserType.IsActive
            };
            await _dbContext.AppUserTypes.AddAsync(userType);
            await _dbContext.SaveChangesAsync();
            return appUserType;
        }

        public async Task<AppUserType> DeleteAppUserTypeAsync(int appUserTypeId)
        {
            var toDelete = await _dbContext.AppUserTypes.Where(a => a.AppUserTypeId == appUserTypeId).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.AppUserTypes.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }

        public async Task<GetAppUserTypeDto> GetAppUserTypeAsync(int appUserTypeId)
        {
            return await _dbContext.AppUserTypes.Where(a => a.AppUserTypeId == appUserTypeId)
                .Select(a => new GetAppUserTypeDto
                {
                    AppUserTypeId = a.AppUserTypeId,
                    AppUserTypeName = a.AppUserTypeName,
                    IsActive = a.IsActive
                }).FirstOrDefaultAsync();                           
        }

        public async Task<IEnumerable<GetAppUserTypeDto>> GetAppUserTypesAsync()
        {
            return await _dbContext.AppUserTypes.Select(a => new GetAppUserTypeDto
               {
                   AppUserTypeId = a.AppUserTypeId,
                   AppUserTypeName = a.AppUserTypeName,
                   IsActive = a.IsActive
               }).ToListAsync();
        }

        public async Task<GetAppUserTypeDto> UpdateAppUserTypeAsync(GetAppUserTypeDto appUserType)
        {
            AppUserType userType = new AppUserType
            {
                AppUserTypeId = appUserType.AppUserTypeId,
                AppUserTypeName = appUserType.AppUserTypeName,
                IsActive = appUserType.IsActive
            };
            _dbContext.Entry(userType).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return appUserType;
        }
    }
}
