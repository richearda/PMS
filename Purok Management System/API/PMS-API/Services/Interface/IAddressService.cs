using PMS_API.DTO.Address;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{

    public interface IAddressService
    {
        /// <summary>
        /// Insert a new address to the database.
        /// </summary>
        /// <param name="address">The address to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted address.
        /// </returns>
        Task<Address> CreateAddressAsync(CreateAddressDto address);
        /// <summary>
        /// Get an address using the address id from the database.
        /// </summary>
        /// <param name="Id">The id of the address to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the address.
        /// </returns>
        Task<GetAddressDto> GetAddressAsync(int Id);
        /// <summary>
        /// Update an address from the database.
        /// </summary>
        /// <param name="address">The address to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated address.
        /// </returns>
        Task<Address> UpdateAddressAsync(Address address);
        /// <summary>
        /// Delete an address from the database using the address id.
        /// </summary>
        /// <param name="Id">The id of the address to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted address.
        /// </returns>
        Task<Address> DeleteAddressAsync(int Id);
        /// <summary>
        /// Get a list of address from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable Address.
        /// </returns>
        Task<IEnumerable<GetAddressDto>> GetAllAddressAsync();
    }
}
