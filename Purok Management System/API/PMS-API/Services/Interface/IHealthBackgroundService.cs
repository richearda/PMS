using PMS_API.DTO.HealthBackground;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IHealthBackgroundService
    {
        /// <summary>
        /// Insert a new healthbackground to the database.
        /// </summary>
        /// <param name="healthBackground">The healthbackground to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted healthbackground.
        /// </returns>
        Task<CreateHealthBackgroundDto> CreateHealthBackgroundAsync(CreateHealthBackgroundDto healthBackground);
        /// <summary>
        /// Get a healthbackground using the healthbackground id from the database.
        /// </summary>
        /// <param name="Id">The id of the healthbackground to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the healthbackground.
        /// </returns>
        Task<GetHealthBackgroundDto> GetHealthBackgroundAsync(int Id);
        /// <summary>
        /// Update a healthbackground from the database.
        /// </summary>
        /// <param name="healthBackground">The healthbackground to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated healthbackground.
        /// </returns>
        Task<HealthBackground> UpdateHealthBackgroundAsync(HealthBackground healthBackground);
        /// <summary>
        /// Delete a healthbackground from the database using the healthbackground id.
        /// </summary>
        /// <param name="Id">The id of the healthbackground to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted healthbackground.
        /// </returns>
        Task<HealthBackground> DeleteHealthBackgroundAsync(int Id);
        /// <summary>
        /// Get a list of Healthbackground from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable HealthBackground.
        /// </returns>
        Task<IEnumerable<GetHealthBackgroundDto>> GetAllHealthBackgroundsAsync();
    }
}
