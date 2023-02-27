using PMS_API.DTO.Request;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IRequestService
    {
        /// <summary>
        /// Insert a new request to the database.
        /// </summary>
        /// <param name="request">The request to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted request.
        /// </returns>
        Task<CreateRequestDto> CreateRequestAsync(CreateRequestDto request);
        /// <summary>
        /// Get a request using the request id from the database.
        /// </summary>
        /// <param name="Id">The id of the request to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the request.
        /// </returns>
        Task<GetRequestDto> GetRequestAsync(int Id);
        /// <summary>
        /// Update a request from the database.
        /// </summary>
        /// <param name="request">The request to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated request.
        /// </returns>
        Task<Request> UpdateRequestAsync(Request request);
        /// <summary>
        /// Delete a request from the database using the request id.
        /// </summary>
        /// <param name="Id">The id of the request to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted request.
        /// </returns>
        Task<Request> DeleteRequestAsync(int Id);
        /// <summary>
        /// Get a list of Request from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable Request.
        /// </returns>
        Task<IEnumerable<GetRequestDto>> GetAllRequestsAsync();
    }
}
