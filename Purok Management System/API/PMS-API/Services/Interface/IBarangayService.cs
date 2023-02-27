using PMS_API.DTO.Barangay;
using PMS_API.DTO.PurokSitio;
using PMS_API.Helpers;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IBarangayService
    {
        /// <summary>
        /// Insert a new barangay to the database.
        /// </summary>
        /// <param name="barangay">The barangay to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted address.
        /// </returns>
        Task<CreateBarangayDto> CreateBarangayAsync(CreateBarangayDto barangay);
        /// <summary>
        /// Get a barangay using the barangay id from the database.
        /// </summary>
        /// <param name="Id">The id of the barangay to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the barangay.
        /// </returns>
        Task<GetBarangayDto> GetBarangayAsync(int Id);
        /// <summary>
        /// Update a barangay from the database.
        /// </summary>
        /// <param name="barangay">The barangay to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated barangay.
        /// </returns>
        Task<CreateBarangayDto> UpdateBarangayAsync(CreateBarangayDto barangay);
        /// <summary>
        /// Delete a barangay from the database using the barangay id.
        /// </summary>
        /// <param name="Id">The id of the barangay to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted barangay.
        /// </returns>
        Task<Barangay> DeleteBarangayAsync(int Id);
        /// <summary>
        /// Get a list of barangay from the database.
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable Barangay.
        /// </returns>
        Task<IEnumerable<GetBarangayDto>> GetAllBarangayAsync();
        Task<PagedList<GetBarangayDto>> GetAllBarangayWithParamsAsync(BarangayParams barangayParams);
        Task<IEnumerable<GetPurokSitioDto>> GetAllPurokSitioByBarangayIdAsync(int Id);
    }
}
