using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.CivilStatus;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class CivilStatusService : ICivilStatusService
    {
        private readonly DatabaseContext _dbContext;

        public CivilStatusService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateCivilStatusDto> CreateCivilStatusAsync(CreateCivilStatusDto civilStatus)
        {
            var civilStatusModel = new CivilStatus
            {
                CivilStatusName = civilStatus.CivilStatusName,
                IsActive = civilStatus.IsActive
            };
            await _dbContext.CivilStatuses.AddAsync(civilStatusModel);
            await _dbContext.SaveChangesAsync();
            return civilStatus;
        }

        public async Task<CivilStatus> DeleteCivilStatusAsync(int Id)
        {
            var toDelete = await _dbContext.CivilStatuses.Where(c => c.CivilStatusId == Id).FirstOrDefaultAsync();
            if (toDelete != null) {
                _dbContext.CivilStatuses.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }

        public async Task<GetCivilStatusDto> GetCivilStatusAsync(int Id)
        {
            return await _dbContext.CivilStatuses.AsNoTracking().Where(c => c.CivilStatusId == Id).Select(c => new GetCivilStatusDto
            {
                CivilStatusId = c.CivilStatusId,
                CivilStatusName = c.CivilStatusName,
                IsActive = c.IsActive,
            }).FirstOrDefaultAsync();
        }

        public async Task<CivilStatus> UpdateCivilStatusAsync(CivilStatus civilStatus)
        {
            _dbContext.Entry(civilStatus).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return civilStatus;
        }

        public async Task<IEnumerable<GetCivilStatusDto>> GetAllCivilStatusAsync()
        {
            return await _dbContext.CivilStatuses.Select(c => new GetCivilStatusDto
            {
                CivilStatusId = c.CivilStatusId,
                CivilStatusName = c.CivilStatusName,
                IsActive = c.IsActive,
            }).ToListAsync();
        }
    }
}
