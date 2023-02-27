using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.RequestType;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class RequestTypeService : IRequestTypeService
    {
        private readonly DatabaseContext _dbContext;

        public RequestTypeService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateRequestTypeDto> CreateRequestTypeAsync(CreateRequestTypeDto requestType)
        {
            var requestTypeModel = new RequestType
            {
                RequestTypeName = requestType.RequestTypeName,
                IsActive = requestType.IsActive
            };
            await _dbContext.RequesTypes.AddAsync(requestTypeModel);
            await _dbContext.SaveChangesAsync();
            return requestType;
        }

        public async Task<RequestType> DeleteRequestTypeAsync(int Id)
        {
            var toDelete = await _dbContext.RequesTypes.Where(r => r.RequestTypeId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.RequesTypes.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }

        public async Task<GetRequestTypeDto> GetRequestTypeAsync(int Id)
        {
            return await _dbContext.RequesTypes.AsNoTracking().Where(r => r.RequestTypeId == Id).Select(r => new GetRequestTypeDto
            {
                RequestTypeId = r.RequestTypeId,
                RequestTypeName = r.RequestTypeName,
                IsActive = r.IsActive
            }).FirstOrDefaultAsync();
        }

        public async Task<RequestType> UpdateRequestTypeAsync(RequestType requestType)
        {
            _dbContext.Entry(requestType).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return requestType;
        }

        public async Task<IEnumerable<GetRequestTypeDto>> GetAllRequestTypesAsync()
        {
            return await _dbContext.RequesTypes.Select(r => new GetRequestTypeDto
            {
                RequestTypeId = r.RequestTypeId,
                RequestTypeName = r.RequestTypeName,
                IsActive = r.IsActive
            }).ToListAsync();
        }
    }
}
