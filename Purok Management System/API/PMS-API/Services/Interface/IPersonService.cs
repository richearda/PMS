using PMS_API.DTO.Person;
using PMS_API.DTO.PersonDtos;
using PMS_API.Helpers;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface IPersonService
    {
        /// <summary>
        /// Insert a new person to the database.
        /// </summary>
        /// <param name="person">The person to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted person.
        /// </returns>
        Task<Person> CreatePersonAsync(CreatePersonDto person);
        /// <summary>
        /// Get a person using the person id from the database.
        /// </summary>
        /// <param name="Id">The id of the person to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the person.
        /// </returns>
        Task<GetPersonDto> GetPersonAsync(int Id);
        /// <summary>
        /// Update a person from the database.
        /// </summary>
        /// <param name="person">The person to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated person.
        /// </returns>
        Task<Person> UpdatePersonAsync(Person person);
        /// <summary>
        /// Delete a person from the database using the person id.
        /// </summary>
        /// <param name="Id">The id of the person to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted person.
        /// </returns>
        Task<Person> DeletePersonAsync(int Id);
        /// <summary>
        /// Get a list of person from the database.
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable Person.
        /// </returns>
        Task<PagedList<GetPersonDto>> GetAllPersonsAsync(PersonParams userParams);
    }
}
