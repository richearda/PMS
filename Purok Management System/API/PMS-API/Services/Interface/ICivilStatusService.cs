using PMS_API.DTO.CivilStatus;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface ICivilStatusService
    {
        /// <summary>
        /// Insert a new civilstatus to the database.
        /// </summary>
        /// <param name="civilStatus">The civilstatus to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted civilstatus.
        /// </returns>
        Task<CreateCivilStatusDto> CreateCivilStatusAsync(CreateCivilStatusDto civilStatus);
        /// <summary>
        /// Get a civilstatus using the civilstatus id from the database.
        /// </summary>
        /// <param name="Id">The id of the civilstatus to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the civilstatus.
        /// </returns>
        Task<GetCivilStatusDto> GetCivilStatusAsync(int Id);
        /// <summary>
        /// Update a civilstatus from the database.
        /// </summary>
        /// <param name="civilStatus">The civilstatus to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated civilstatus.
        /// </returns>
        Task<CivilStatus> UpdateCivilStatusAsync(CivilStatus civilStatus);
        /// <summary>
        /// Delete a civilstatus from the database using the civilstatus id.
        /// </summary>
        /// <param name="Id">The id of the civilstatus to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted civilstatus.
        /// </returns>
        Task<CivilStatus> DeleteCivilStatusAsync(int Id);
        /// <summary>
        /// Get a list of CivilStatus from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable CivilStatus.
        /// </returns>
        Task<IEnumerable<GetCivilStatusDto>> GetAllCivilStatusAsync();
    }
}
