using PMS_API.DTO.PreExistingCondition;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IPreExistingConditionService
    {
        /// <summary>
        /// Insert a new preexistingcondition to the database.
        /// </summary>
        /// <param name="preExistingCondition">The preexistingcondition to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted preexistingcondition.
        /// </returns>
        Task<CreatePreExistingConditionDto> CreatePreExistingConditionAsync(CreatePreExistingConditionDto preExistingCondition);
        /// <summary>
        /// Get a preexistingcondition using the preexistingcondition id from the database.
        /// </summary>
        /// <param name="Id">The id of the preexistingcondition to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the preexistingcondition.
        /// </returns>
        Task<GetPreExistingConditionDto> GetPreExistingConditionAsync(int Id);
        /// <summary>
        /// Update a preexistingcondition from the database.
        /// </summary>
        /// <param name="preExistingCondition">The preexistingcondition to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated preexistingcondition.
        /// </returns>
        Task<CreatePreExistingConditionDto> UpdatePreExistingConditionAsync(CreatePreExistingConditionDto preExistingCondition);
        /// <summary>
        /// Delete a preexistingcondition from the database using the preexistingcondition id.
        /// </summary>
        /// <param name="Id">The id of the preexistingcondition to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted preexistingcondition.
        /// </returns>
        Task<PreExistingCondition> DeletePreExistingConditionAsync(int Id);
        /// <summary>
        /// Get a list of Preexistingcondition from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable PreExistingCondition.
        /// </returns>
        Task<IEnumerable<GetPreExistingConditionDto>> GetAllPreExistingCondtionAsync();
    }
}
