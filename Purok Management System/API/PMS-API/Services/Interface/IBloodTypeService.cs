using PMS_API.DTO.BloodType;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IBloodTypeService
    {
        /// <summary>
        /// Insert a new bloodtype to the database.
        /// </summary>
        /// <param name="bloodType">The bloodtype to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted bloodtype.
        /// </returns>
        Task<CreateBloodTypeDto> CreateBloodTypeAsync(CreateBloodTypeDto bloodType);
        /// <summary>
        /// Get a bloodtype using the bloodtype id from the database.
        /// </summary>
        /// <param name="Id">The id of the bloodtype to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the bloodtype.
        /// </returns>
        Task<GetBloodTypeDto> GetBloodTypeAsync(int Id);
        /// <summary>
        /// Update a bloodtype from the database.
        /// </summary>
        /// <param name="bloodType">The bloodtype to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated bloodtype.
        /// </returns>
        Task<BloodType> UpdateBloodTypeAsync(BloodType bloodType);
        /// <summary>
        /// Delete a bloodtype from the database using the bloodtype id.
        /// </summary>
        /// <param name="Id">The id of the bloodtype to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted bloodtype.
        /// </returns>
        Task<BloodType> DeleteBloodTypeAsync(int Id);
        /// <summary>
        /// Get a list of Bloodtype from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable Bloodtype.
        /// </returns>
        Task<IEnumerable<GetBloodTypeDto>> GetAllBloodTypeAsync();

    }
}
