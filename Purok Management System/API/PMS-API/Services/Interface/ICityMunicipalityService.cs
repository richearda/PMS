using PMS_API.DTO;
using PMS_API.DTO.Barangay;
using PMS_API.DTO.CityMunicipality;
using PMS_API.Models;

namespace PMS_API.Services.Interface
{
    public interface ICityMunicipalityService
    {
        /// <summary>
        /// Insert a new citymunicipality to the database.
        /// </summary>
        /// <param name="cityMunicipality">The citymunicipality to insert.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the inserted citymunicipality.
        /// </returns>
        Task<CreateCityMunicipalityDto> CreateCityMunicipalityAsync(CreateCityMunicipalityDto cityMunicipality);
        /// <summary>
        /// Get a citymunicipality using the citymunicipality id from the database.
        /// </summary>
        /// <param name="Id">The id of the citymunicipality to get.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the citymunicipality.
        /// </returns>
        Task<GetCityMunicipalityDto> GetCityMunicipalityAsync(int Id);
        /// <summary>
        /// Update a citymunicipality from the database.
        /// </summary>
        /// <param name="cityMunicipality">The citymunicipality to update.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the updated citymunicipality.
        /// </returns>
        Task<CityMunicipality> UpdateCityMunicipalityAsync(CityMunicipality cityMunicipality);
        /// <summary>
        /// Delete a citymunicipality from the database using the citymunicipality id.
        /// </summary>
        /// <param name="Id">The id of the citymunicipality to delete.</param>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains the deleted citymunicipality.
        /// </returns>
        Task<CityMunicipality> DeleteCityMunicipalityAsync(int Id);
        /// <summary>
        /// Get a list of CityMunicipality from the database
        /// </summary>
        /// <returns>
        /// A task that represents asynchronous operation.
        /// The task result contains a list of IEnumerable CityMunicipality.
        /// </returns>
        Task<IEnumerable<GetCityMunicipalityDto>> GetAllCityMunicipalityAsync();
        Task<IEnumerable<GetBarangayDto>> GetAllBarangayByCityMunicipalityIdAsync(int Id);

    }
}
