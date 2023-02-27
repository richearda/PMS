using PMS_API.DTO.VaccineTaken;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IVaccineTakenService
    {
        /// <summary>
        /// Insert a new vaccinetaken to the database.
        /// </summary>
        /// <param name="vaccineTaken">The vaccinetaken to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted vaccinetaken.
        /// </returns>
        Task<CreateVaccineTakenDto> CreateVaccineTakenAsync(CreateVaccineTakenDto vaccineTaken);
        /// <summary>
        /// Get a vaccinetaken using the vaccinetaken id from the database.
        /// </summary>
        /// <param name="Id">The id of the vaccinetaken to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the vaccinetaken.
        /// </returns>
        Task<GetVaccineTakenDto> GetVaccineTakenAsync(int Id);
        /// <summary>
        /// Update a vaccinetaken from the database.
        /// </summary>
        /// <param name="vaccineTaken">The vaccinetaken to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated vaccinetaken.
        /// </returns>
        Task<VaccineTaken> UpdateVaccineTakenAsync(VaccineTaken vaccineTaken);
        /// <summary>
        /// Delete a vaccinetaken from the database using the vaccinetaken id.
        /// </summary>
        /// <param name="Id">The id of the vaccinetaken to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted vaccinetaken.
        /// </returns>
        Task<VaccineTaken> DeleteVaccineTakenAsync(int Id);
        /// <summary>
        /// Get a list of Vaccinetaken from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable VaccineTaken.
        /// </returns>
        Task<IEnumerable<GetVaccineTakenDto>> GetAllVaccineTakenAsync();
    }
}
