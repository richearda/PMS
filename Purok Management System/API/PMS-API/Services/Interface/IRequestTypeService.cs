using PMS_API.DTO.RequestType;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IRequestTypeService
    {
        /// <summary>
        /// Insert a new requesttype to the database.
        /// </summary>
        /// <param name="requestType">The requesttype to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted requesttype.
        /// </returns>
        Task<CreateRequestTypeDto> CreateRequestTypeAsync(CreateRequestTypeDto requestType);
        /// <summary>
        /// Get a requesttype using the requesttype id from the database.
        /// </summary>
        /// <param name="Id">The id of the requesttype to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the requesttype.
        /// </returns>
        Task<GetRequestTypeDto> GetRequestTypeAsync(int Id);
        /// <summary>
        /// Update a requesttype from the database.
        /// </summary>
        /// <param name="requestType">The requesttype to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated requesttype.
        /// </returns>
        Task<RequestType> UpdateRequestTypeAsync(RequestType requestType);
        /// <summary>
        /// Delete a requesttype from the database using the requesttype id.
        /// </summary>
        /// <param name="Id">The id of the requesttype to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted requesttype.
        /// </returns>
        Task<RequestType> DeleteRequestTypeAsync(int Id);
        /// <summary>
        /// Get a list of RequestType from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable RequestType.
        /// </returns>
        Task<IEnumerable<GetRequestTypeDto>> GetAllRequestTypesAsync();
    }
}
