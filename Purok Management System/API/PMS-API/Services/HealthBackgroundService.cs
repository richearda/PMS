using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.HealthBackground;
using PMS_API.DTO.PreExistingCondition;
using PMS_API.DTO.VaccineTaken;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class HealthBackgroundService : IHealthBackgroundService
    {
        private readonly DatabaseContext _dbContext;

        public HealthBackgroundService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateHealthBackgroundDto> CreateHealthBackgroundAsync(CreateHealthBackgroundDto healthBackground)
        {
            var healthBackgroundModel = new HealthBackground
            {
                IsMalnurish = healthBackground.IsMalnurish,
                IsPwd = healthBackground.IsPwd,
                PreExistingConditionId = healthBackground.PreExistingConditionId,
                VaccineTakenId = healthBackground.VaccineTakenId,
                IsActive = healthBackground.IsActive
            };
            await _dbContext.HealthBackgrounds.AddAsync(healthBackgroundModel);
            await _dbContext.SaveChangesAsync();
            return healthBackground;
        }

        public async Task<HealthBackground> DeleteHealthBackgroundAsync(int Id)
        {
            var toDelete = await _dbContext.HealthBackgrounds.Where(h => h.HealthBackgroundId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.HealthBackgrounds.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }
        public async Task<GetHealthBackgroundDto> GetHealthBackgroundAsync(int Id)
        {
            return await _dbContext.HealthBackgrounds.AsNoTracking().Where(h => h.HealthBackgroundId == Id).Select(h => new GetHealthBackgroundDto
            {
                HealthBackgroundId = h.HealthBackgroundId,
                IsMalnurish = h.IsMalnurish,
                IsPwd = h.IsPwd,
                PreExistingCondition = new GetPreExistingConditionDto
                {
                    ConditionName = h.PreExistingCondition.ConditionName
                },
                VaccineTaken = new GetVaccineTakenDto
                {
                    VaccineName = h.VaccineTaken.VaccineName
                },
                IsActive = h.IsActive
            }).FirstOrDefaultAsync();
        }

        public async Task<HealthBackground> UpdateHealthBackgroundAsync(HealthBackground healthBackground)
        {
            _dbContext.Entry(healthBackground).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return healthBackground;
        }

        public async Task<IEnumerable<GetHealthBackgroundDto>> GetAllHealthBackgroundsAsync()
        {
            return await _dbContext.HealthBackgrounds.Select(h => new GetHealthBackgroundDto
            {
                HealthBackgroundId = h.HealthBackgroundId,
                IsMalnurish = h.IsMalnurish,
                IsPwd = h.IsPwd,
                PreExistingCondition = new GetPreExistingConditionDto
                {
                    ConditionName = h.PreExistingCondition.ConditionName
                },
                VaccineTaken = new GetVaccineTakenDto { 
                VaccineName = h.VaccineTaken.VaccineName
                },
                IsActive = h.IsActive                
            }).ToListAsync();
        }
    }
}
