using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO;
using PMS_API.DTO.Barangay;
using PMS_API.DTO.CityMunicipality;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class CityMunicipalityService : ICityMunicipalityService
    {
        private readonly DatabaseContext _dbContext;

        public CityMunicipalityService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateCityMunicipalityDto> CreateCityMunicipalityAsync(CreateCityMunicipalityDto cityMunicipality)
        {
            var cityMunicipalityModel = new CityMunicipality
            {
                CityMunicipalityName = cityMunicipality.CityMunicipalityName,
                ZipCode = cityMunicipality.ZipCode,
                IsActive = cityMunicipality.IsActive
            };
            await _dbContext.CityMunicipalities.AddAsync(cityMunicipalityModel);
            await _dbContext.SaveChangesAsync();
            return cityMunicipality;
        }

        public async Task<CityMunicipality> DeleteCityMunicipalityAsync(int Id)
        {
            var toDelete = await _dbContext.CityMunicipalities.Where(c => c.CityMunicipalityId== Id).FirstOrDefaultAsync();
            if(toDelete != null)
            {
                _dbContext.CityMunicipalities.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }

        public async Task<GetCityMunicipalityDto> GetCityMunicipalityAsync(int Id)
        {
            return await _dbContext.CityMunicipalities.Where(c => c.CityMunicipalityId == Id).Select(c => new GetCityMunicipalityDto
            {
                CityMunicipalityId = c.CityMunicipalityId,
                CityMunicipalityName = c.CityMunicipalityName,
                ZipCode = c.ZipCode,
                IsActive = c.IsActive
            }).FirstOrDefaultAsync();
        }

        public async Task<CityMunicipality> UpdateCityMunicipalityAsync(CityMunicipality cityMunicipality)
        {
            _dbContext.Entry(cityMunicipality).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return cityMunicipality;
        }

        public async Task<IEnumerable<GetCityMunicipalityDto>> GetAllCityMunicipalityAsync()
        {
            return await _dbContext.CityMunicipalities.Select(c => new GetCityMunicipalityDto
            {
                CityMunicipalityId = c.CityMunicipalityId,
                CityMunicipalityName = c.CityMunicipalityName,
                ZipCode = c.ZipCode,
                IsActive = c.IsActive,
            }).ToListAsync();
        }

        public async Task<IEnumerable<GetBarangayDto>> GetAllBarangayByCityMunicipalityIdAsync(int Id)
        {
            return await _dbContext.Barangays.Where(b => b.CityMunicipalityId == Id)
                 .Select(c => new GetBarangayDto
                 {
                     BarangayId = c.BarangayId,
                     BarangayName = c.BarangayName,
                     IsActive = c.IsActive,
                 }).ToListAsync();
        }
    }
}
