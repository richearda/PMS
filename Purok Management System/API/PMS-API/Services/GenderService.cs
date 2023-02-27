using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.Gender;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class GenderService : IGenderService
    {
        private readonly DatabaseContext _dbContext;

        public GenderService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateGenderDto> CreateGenderAsync(CreateGenderDto gender)
        {
            var genderModel = new Gender
            {
                GenderName = gender.GenderName,
                IsActive = gender.IsActive
            };
            await _dbContext.Genders.AddAsync(genderModel);
            await _dbContext.SaveChangesAsync();
            return gender;
        }

        public async Task<Gender> DeleteGenderAsync(int Id)
        {
            var toDelete = await _dbContext.Genders.Where(g => g.GenderId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.Genders.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }

        public async Task<GetGenderDto> GetGenderAsync(int Id)
        {
            return await _dbContext.Genders.AsNoTracking().Where(g => g.GenderId == Id).Select(g => new GetGenderDto
            {
                GenderId = g.GenderId,
                GenderName = g.GenderName,
                IsActive = g.IsActive
            }).FirstOrDefaultAsync();
        }

        public async Task<Gender> UpdateGenderAsync(Gender gender)
        {
            _dbContext.Entry(gender).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return gender;
        }

        public async Task<IEnumerable<GetGenderDto>> GetAllGenderAsync()
        {
            return await _dbContext.Genders.Select(g => new GetGenderDto
            {
                GenderId = g.GenderId,
                GenderName = g.GenderName,
                IsActive = g.IsActive
            }).ToListAsync();
        }
    }
}
