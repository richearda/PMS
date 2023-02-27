using PMS_API.DTO.Gender;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IGenderService
    {
        /// <summary>
        /// Insert a new gender to the database.
        /// </summary>
        /// <param name="gender">The gender to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted gender.
        /// </returns>
        Task<CreateGenderDto> CreateGenderAsync(CreateGenderDto gender);
        /// <summary>
        /// Get a gender using the gender id from the database.
        /// </summary>
        /// <param name="Id">The id of the gender to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the gender.
        /// </returns>
        Task<GetGenderDto> GetGenderAsync(int Id);
        /// <summary>
        /// Update a gender from the database.
        /// </summary>
        /// <param name="gender">The gender to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated gender.
        /// </returns>
        Task<Gender> UpdateGenderAsync(Gender gender);
        /// <summary>
        /// Delete a gender from the database using the gender id.
        /// </summary>
        /// <param name="Id">The id of the gender to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted gender.
        /// </returns>
        Task<Gender> DeleteGenderAsync(int Id);
        /// <summary>
        /// Get a list of gender from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable Gender.
        /// </returns>
        Task<IEnumerable<GetGenderDto>> GetAllGenderAsync();
    }
}
