using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.Citizenship;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class CitizenshipService : ICitizenshipService
    {
        private readonly DatabaseContext _dbContext;

        public CitizenshipService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateCitizenshipDto> CreateCitizenshipAsync(CreateCitizenshipDto citizenship)
        {
            var citizenshipModel = new Citizenship
            {
                CitizenshipName = citizenship.CitizenshipName,
                IsActive = citizenship.IsActive
            };
            await _dbContext.Citizenships.AddAsync(citizenshipModel);
            await _dbContext.SaveChangesAsync();
            return citizenship;
        }

        public async Task<Citizenship> DeleteCitizenshipAsync(int Id)
        {
            var toDelete = await _dbContext.Citizenships.Where(c => c.CitizenshipId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.Citizenships.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }

        public async Task<GetCitizenshipDto> GetCitizenshipAsync(int Id)
        {
            return await _dbContext.Citizenships.AsNoTracking().Where(c => c.CitizenshipId == Id).Select(c => new GetCitizenshipDto
            {
                CitizenshipId = c.CitizenshipId,
                CitizenshipName = c.CitizenshipName,
                IsActive = c.IsActive
            }).FirstOrDefaultAsync();
        }

        public async Task<Citizenship> UpdateCitizenshipAsync(Citizenship citizenship)
        {
           _dbContext.Entry(citizenship).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return citizenship;
        }

        public async Task<IEnumerable<GetCitizenshipDto>> GetAllCitizenshipAsync()
        {
            return await _dbContext.Citizenships.Select(c => new GetCitizenshipDto
            {
                CitizenshipId = c.CitizenshipId,
                CitizenshipName = c.CitizenshipName,
                IsActive = c.IsActive
            }).ToListAsync();
        }
    }
}
