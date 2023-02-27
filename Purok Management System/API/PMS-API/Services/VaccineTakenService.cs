using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.VaccineTaken;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class VaccineTakenService : IVaccineTakenService
    {
        private readonly DatabaseContext _dbContext;

        public VaccineTakenService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateVaccineTakenDto> CreateVaccineTakenAsync(CreateVaccineTakenDto vaccineTaken)
        {
            var vaccineTakenModel = new VaccineTaken
            {
                VaccineName = vaccineTaken.VaccineName,
                IsActive = vaccineTaken.IsActive
            };
            await _dbContext.VaccinesTaken.AddAsync(vaccineTakenModel);
            await _dbContext.SaveChangesAsync();
            return vaccineTaken;
        }

        public async Task<VaccineTaken> DeleteVaccineTakenAsync(int Id)
        {
            var toDelete = await _dbContext.VaccinesTaken.Where(v => v.VaccineTakenId == Id).FirstOrDefaultAsync();
            if(toDelete != null)
            {
                _dbContext.VaccinesTaken.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }
  
        public async Task<GetVaccineTakenDto> GetVaccineTakenAsync(int Id)
        {
            return await _dbContext.VaccinesTaken.AsNoTracking().Where(v => v.VaccineTakenId == Id).Select(v => new GetVaccineTakenDto
            {
                VaccineTakenId = v.VaccineTakenId,
                VaccineName = v.VaccineName,
                IsActive = v.IsActive
            }).FirstOrDefaultAsync();
        }

        public async Task<VaccineTaken> UpdateVaccineTakenAsync(VaccineTaken vaccineTaken)
        {
            _dbContext.Entry(vaccineTaken).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return vaccineTaken;
        }

        public async Task<IEnumerable<GetVaccineTakenDto>> GetAllVaccineTakenAsync()
        {
            return await _dbContext.VaccinesTaken.Select(v => new GetVaccineTakenDto
            {
                VaccineTakenId = v.VaccineTakenId,
                VaccineName = v.VaccineName,
                IsActive = v.IsActive
            }).ToListAsync();
        }
    }
}
