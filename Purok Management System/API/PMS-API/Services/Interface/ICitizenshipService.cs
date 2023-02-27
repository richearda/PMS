using PMS_API.DTO.Citizenship;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface ICitizenshipService
    {
        /// <summary>
        /// Insert a new citizenship to the database.
        /// </summary>
        /// <param name="citizenship">The citizenship to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted citizenship.
        /// </returns>
        Task<CreateCitizenshipDto> CreateCitizenshipAsync(CreateCitizenshipDto citizenship);
        /// <summary>
        /// Get a citizenship using the citizenship id from the database.
        /// </summary>
        /// <param name="Id">The id of the citizenship to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the citizenship.
        /// </returns>
        Task<GetCitizenshipDto> GetCitizenshipAsync(int Id);
        /// <summary>
        /// Update a citizenship from the database.
        /// </summary>
        /// <param name="citizenship">The citizenship to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated citizenship.
        /// </returns>
        Task<Citizenship> UpdateCitizenshipAsync(Citizenship citizenship);
        /// <summary>
        /// Delete a citizenship from the database using the citizenship id.
        /// </summary>
        /// <param name="Id">The id of the citizenship to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted citizenship.
        /// </returns>
        Task<Citizenship> DeleteCitizenshipAsync(int Id);
        /// <summary>
        /// Get a list of Citizenship from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable Citizenship.
        /// </returns>
        Task<IEnumerable<GetCitizenshipDto>> GetAllCitizenshipAsync();
    }
}
