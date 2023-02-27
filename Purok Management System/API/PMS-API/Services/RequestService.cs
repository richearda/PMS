using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.Request;
using PMS_API.DTO.RequestType;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class RequestService : IRequestService
    {
        private readonly DatabaseContext _dbContext;

        public RequestService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CreateRequestDto> CreateRequestAsync(CreateRequestDto request)
        {
            var requestModel = new Request
            {
                DateRequested = request.DateRequested,
                PickUpDate = request.PickUpDate,
                Status = request.Status,
                RequestTypeId = request.RequestTypeId,
                PersonId = request.PersonId,
            };
            await _dbContext.Requests.AddAsync(requestModel);
            await _dbContext.SaveChangesAsync();
            return request;
        }

        public async Task<Request> DeleteRequestAsync(int Id)
        {
            var toDelete = await _dbContext.Requests.Where(r => r.RequestId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.Requests.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }

        public async Task<GetRequestDto> GetRequestAsync(int Id)
        {
            return await _dbContext.Requests.Where(r => r.RequestId == Id).Select(s => new GetRequestDto
            {
                RequestId = s.RequestId,
                DateRequested = s.DateRequested,
                PickUpDate = s.PickUpDate,
                Status = s.Status,
                RequestType = new GetRequestTypeDto
                {
                    RequestTypeName = s.RequestType.RequestTypeName
                }

            }).FirstOrDefaultAsync();
        }

        public async Task<Request> UpdateRequestAsync(Request request)
        {
            _dbContext.Entry(request).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return request;
        }

        public async Task<IEnumerable<GetRequestDto>> GetAllRequestsAsync()
        {
            return await _dbContext.Requests.Select(s => new GetRequestDto
            {
                RequestId = s.RequestId,
                DateRequested = s.DateRequested,
                PickUpDate = s.PickUpDate,
                Status = s.Status,
                RequestType = new GetRequestTypeDto
                {
                    RequestTypeName = s.RequestType.RequestTypeName
                }
                
            }).ToListAsync();
        }
    }
}
