using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.Barangay;
using PMS_API.DTO.PurokSitio;
using PMS_API.Helpers;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class PurokSitioService : IPurokSitioService
    {
        private readonly DatabaseContext _dbContext;

        public PurokSitioService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreatePurokSitioDto> CreatePurokSitioAsync(CreatePurokSitioDto purokSitio)
        {
            var purokSitioModel = new PurokSitio
            {
                PurokSitioName = purokSitio.PurokSitioName,
                BarangayId = purokSitio.BarangayId,
                IsActive = purokSitio.IsActive
            };
           await _dbContext.PurokSitios.AddAsync(purokSitioModel);
            await _dbContext.SaveChangesAsync();
            return purokSitio;
        }

        public async Task<PurokSitio> DeletePurokSitioAsync(int Id)
        {
            var toDelete = await _dbContext.PurokSitios.Where(p => p.PurokSitioId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.PurokSitios.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }

        public async Task<GetPurokSitioDto> GetPurokSitioAsync(int Id)
        {
            return await _dbContext.PurokSitios.AsNoTracking().Where(p => p.PurokSitioId == Id).Select(p => new GetPurokSitioDto
            {
                PurokSitioId = p.PurokSitioId,
                PurokSitioName = p.PurokSitioName,
                BarangayName = p.Barangay.BarangayName,
                IsActive = p.IsActive
            }).FirstOrDefaultAsync();
        }

        public async Task<PurokSitio> UpdatePurokSitioAsync(PurokSitio purokSitio)
        {
           _dbContext.Entry(purokSitio).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return purokSitio;
        }

        public async Task<IEnumerable<GetPurokSitioDto>> GetAllPurokSitioAsync()
        {
            return await _dbContext.PurokSitios.AsNoTracking().Select(p => new GetPurokSitioDto
            {
                PurokSitioId = p.PurokSitioId,
                PurokSitioName = p.PurokSitioName,
                BarangayName = p.Barangay.BarangayName,
                IsActive = p.IsActive
            }).ToListAsync();
        }

        public async Task<PagedList<GetPurokSitioDto>> GetAllPurokSitioWithParamsAsync(PurokSitioParams purokSitioParams)
        {
            var purokSitios = _dbContext.PurokSitios.Where(p => p.Barangay.BarangayName == purokSitioParams.BarangayName).Select(p => new GetPurokSitioDto
            {
                PurokSitioId = p.PurokSitioId,
                PurokSitioName = p.PurokSitioName,
                BarangayName = p.Barangay.BarangayName,
                IsActive = p.IsActive
            }).AsQueryable();

            return await PagedList<GetPurokSitioDto>.CreateAsync(purokSitios, purokSitioParams.PageNumber, purokSitioParams.PageSize);
        }
    }
}
