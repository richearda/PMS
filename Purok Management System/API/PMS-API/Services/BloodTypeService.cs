using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.BloodType;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class BloodTypeService : IBloodTypeService
    {
        private readonly DatabaseContext _dbContext;

        public BloodTypeService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateBloodTypeDto> CreateBloodTypeAsync(CreateBloodTypeDto bloodType)
        {
            var bloodTypeModel = new BloodType
            {
                BloodTypeName = bloodType.BloodTypeName,
                IsActive = bloodType.IsActive
            };
            await _dbContext.BloodTypes.AddAsync(bloodTypeModel);
            await _dbContext.SaveChangesAsync();
            return bloodType;
        }

        public async Task<BloodType> DeleteBloodTypeAsync(int Id)
        {
            var toDelete = await _dbContext.BloodTypes.Where(b => b.BloodTypeId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.BloodTypes.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
                return toDelete;
        }
     
        public async Task<GetBloodTypeDto> GetBloodTypeAsync(int Id)
        {
            return await _dbContext.BloodTypes.AsNoTracking().Where(b => b.BloodTypeId == Id).Select(b => new GetBloodTypeDto
            {
                BloodTypeId = b.BloodTypeId,
                BloodTypeName = b.BloodTypeName,
                IsActive = b.IsActive,
            }).FirstOrDefaultAsync();
        }

        public async Task<BloodType> UpdateBloodTypeAsync(BloodType bloodType)
        {
            _dbContext.Entry(bloodType).State= EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return bloodType;
        }

        public async Task<IEnumerable<GetBloodTypeDto>> GetAllBloodTypeAsync()
        {
            return await _dbContext.BloodTypes.Select(b => new GetBloodTypeDto
            {
                BloodTypeId = b.BloodTypeId,
                BloodTypeName = b.BloodTypeName,
                IsActive = b.IsActive,
            }).ToListAsync();
        }

    }
}
