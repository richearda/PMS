using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.Barangay;
using PMS_API.DTO.Person;
using PMS_API.DTO.PurokSitio;
using PMS_API.Helpers;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
   
    public class BarangayService : IBarangayService
    {
        private readonly DatabaseContext _dbContext;

        public BarangayService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateBarangayDto> CreateBarangayAsync(CreateBarangayDto barangay)
        {
            var barangayModel = new Barangay
            {
                BarangayName = barangay.BarangayName,
                CityMunicipalityId = barangay.CityMunicipalityId,
                IsActive = barangay.IsActive
            };
            await _dbContext.Barangays.AddAsync(barangayModel);
            await _dbContext.SaveChangesAsync();
            return barangay;
        }

        public async Task<Barangay> DeleteBarangayAsync(int Id)
        {
            var toDelete = await _dbContext.Barangays.Where(b => b.BarangayId == Id).FirstOrDefaultAsync();
            if(toDelete != null)
            {
                _dbContext.Barangays.Remove(toDelete);
                await _dbContext.SaveChangesAsync();             
            }
            return toDelete;
        }

        public async Task<GetBarangayDto> GetBarangayAsync(int Id)
        {
            return await _dbContext.Barangays.AsNoTracking().Where(b => b.BarangayId == Id).Select(b => new GetBarangayDto
            {
                BarangayId = b.BarangayId,
                BarangayName = b.BarangayName,
                CityMunicipalityName = b.CityMunicipality.CityMunicipalityName,
                ZipCode = b.CityMunicipality.ZipCode,
                IsActive = b.IsActive
            }).FirstOrDefaultAsync();
        }
      
        public async Task<CreateBarangayDto> UpdateBarangayAsync(CreateBarangayDto barangay)
        {
            Barangay barangayToUpdate = new Barangay
            {
                BarangayId = barangay.barangayId,
                BarangayName = barangay.BarangayName,
                IsActive = barangay.IsActive
            };
            _dbContext.Entry(barangayToUpdate).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return barangay;
        }

        public async Task<IEnumerable<GetBarangayDto>> GetAllBarangayAsync()
        {
            return await _dbContext.Barangays.Select(b => new GetBarangayDto
            {
                BarangayId = b.BarangayId,
                BarangayName = b.BarangayName,
                CityMunicipalityName = b.CityMunicipality.CityMunicipalityName,
                ZipCode = b.CityMunicipality.ZipCode,
                IsActive = b.IsActive,
            }).ToListAsync();
        }

        public async Task<IEnumerable<GetPurokSitioDto>> GetAllPurokSitioByBarangayIdAsync(int Id)
        {
            return await _dbContext.PurokSitios.Where(p => p.BarangayId == Id)
                    .Select(p => new GetPurokSitioDto
                    {
                        PurokSitioId = p.PurokSitioId,
                        PurokSitioName = p.PurokSitioName,
                        IsActive = p.IsActive
                    }).ToListAsync();
        }

        public async Task<PagedList<GetBarangayDto>> GetAllBarangayWithParamsAsync(BarangayParams barangayParams)
        {
            var barangays =  _dbContext.Barangays.Where(b => b.CityMunicipality
                .CityMunicipalityName == barangayParams.CityMunicipalityName)
                .Select(b => new GetBarangayDto
            {
                BarangayId = b.BarangayId,
                BarangayName = b.BarangayName,
                CityMunicipalityName = b.CityMunicipality.CityMunicipalityName,
                ZipCode = b.CityMunicipality.ZipCode,
                IsActive = b.IsActive,
            }).AsQueryable();
            return await PagedList<GetBarangayDto>.CreateAsync(barangays, barangayParams.PageNumber, barangayParams.PageSize);
        }
    }
}
