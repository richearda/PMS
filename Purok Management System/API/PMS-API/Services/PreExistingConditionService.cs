using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.PreExistingCondition;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class PreExistingConditionService : IPreExistingConditionService
    {
        private readonly DatabaseContext _dbContext;

        public PreExistingConditionService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreatePreExistingConditionDto> CreatePreExistingConditionAsync(CreatePreExistingConditionDto preExistingCondition)
        {
            var preExistingConditionModel = new PreExistingCondition
            {
                ConditionName = preExistingCondition.ConditionName,
                IsActive = preExistingCondition.IsActive
            };
            await _dbContext.PreExistingConditions.AddAsync(preExistingConditionModel);
            await _dbContext.SaveChangesAsync();
            return preExistingCondition;
        }

        public async Task<PreExistingCondition> DeletePreExistingConditionAsync(int Id)
        {
            var toDelete = await _dbContext.PreExistingConditions.Where(p => p.PreExistingConditionId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.PreExistingConditions.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }

        public async Task<GetPreExistingConditionDto> GetPreExistingConditionAsync(int Id)
        {
            return await _dbContext.PreExistingConditions.Where(p => p.PreExistingConditionId == Id).Select(p => new GetPreExistingConditionDto
            {
                PreExistingConditionId = p.PreExistingConditionId,
                ConditionName = p.ConditionName,
                IsActive = p.IsActive,
            }).FirstOrDefaultAsync();
        }

        public async Task<CreatePreExistingConditionDto> UpdatePreExistingConditionAsync(CreatePreExistingConditionDto preExistingCondition)
        {
            PreExistingCondition conditionToUpdate = new PreExistingCondition
            {
                PreExistingConditionId = preExistingCondition.ConditionId,
                ConditionName = preExistingCondition.ConditionName,
                IsActive = preExistingCondition.IsActive
            };
            _dbContext.Entry(conditionToUpdate).State= EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return preExistingCondition;
        }

        public async Task<IEnumerable<GetPreExistingConditionDto>> GetAllPreExistingCondtionAsync()
        {
            return await _dbContext.PreExistingConditions.Select(p => new GetPreExistingConditionDto
            {
                PreExistingConditionId = p.PreExistingConditionId,
                ConditionName = p.ConditionName,
                IsActive = p.IsActive,
            }).ToListAsync();
        }
    }
}
