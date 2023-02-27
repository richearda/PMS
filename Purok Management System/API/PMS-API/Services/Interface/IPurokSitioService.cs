using PMS_API.DTO.PurokSitio;
using PMS_API.Helpers;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IPurokSitioService
    {
        /// <summary>
        /// Insert a new puroksitio to the database.
        /// </summary>
        /// <param name="purokSitio">The puroksitio to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted puroksitio.
        /// </returns>
        Task<CreatePurokSitioDto> CreatePurokSitioAsync(CreatePurokSitioDto purokSitio);
        /// <summary>
        /// Get a puroksitio using the puroksitio id from the database.
        /// </summary>
        /// <param name="Id">The id of the puroksitio to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the puroksitio.
        /// </returns>
        Task<GetPurokSitioDto> GetPurokSitioAsync(int Id);
        /// <summary>
        /// Update a puroksitio from the database.
        /// </summary>
        /// <param name="purokSitio">The puroksitio to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated puroksitio.
        /// </returns>
        Task<PurokSitio> UpdatePurokSitioAsync(PurokSitio purokSitio);
        /// <summary>
        /// Delete a puroksitio from the database using the puroksitio id.
        /// </summary>
        /// <param name="Id">The id of the puroksitio to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted puroksitio.
        /// </returns>
        Task<PurokSitio> DeletePurokSitioAsync(int Id);
        /// <summary>
        /// Get a list of Puroksitio from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable PurokSitio.
        /// </returns>
        Task<IEnumerable<GetPurokSitioDto>> GetAllPurokSitioAsync();
        Task<PagedList<GetPurokSitioDto>> GetAllPurokSitioWithParamsAsync(PurokSitioParams purokSitioParams);
    }
}
