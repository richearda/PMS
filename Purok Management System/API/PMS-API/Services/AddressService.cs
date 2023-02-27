using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.Address;
using PMS_API.DTO.Barangay;
using PMS_API.DTO.PurokSitio;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class AddressService : IAddressService
    {
        private readonly DatabaseContext _dbContext;

        public AddressService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
     
        public async Task<Address> CreateAddressAsync(CreateAddressDto address)
        {
            var addressModel = new Address
            {
                HouseBlockLotNo = address.HouseBlockLotNo,
                Street = address.Street,
                BarangayId = address.BarangayId,
                PurokSitioId = address.PurokSitioId,               
            };
             await _dbContext.Addresses.AddAsync(addressModel);
             await _dbContext.SaveChangesAsync();
            return addressModel;
        }

        public async Task<Address> DeleteAddressAsync(int Id)
        {
            var toDelete = await _dbContext.Addresses.Where(a => a.AddressId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                 _dbContext.Addresses.Remove(toDelete);
                await _dbContext.SaveChangesAsync();                
            }
            return toDelete;
        }

        public async Task<GetAddressDto> GetAddressAsync(int Id)
        {
            return await _dbContext.Addresses.AsNoTracking().Where(a => a.AddressId == Id)
            .Select(a => new GetAddressDto
            {
                AddressId = a.AddressId,
                HouseBlockLotNo = a.HouseBlockLotNo,
                Street = a.Street,
                CityMunicipality = a.CityMunicipality.CityMunicipalityName,
                Barangay = a.Barangay.BarangayName,
                PurokSitio = a.PurokSitio.PurokSitioName
                
            }).FirstOrDefaultAsync();
        }
    
        public async Task<Address> UpdateAddressAsync(Address address)
        {
            _dbContext.Entry(address).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return address;
        }

        public async Task<IEnumerable<GetAddressDto>> GetAllAddressAsync()
        {
            return await _dbContext.Addresses.AsNoTracking().Select(a => new GetAddressDto
            {
                AddressId = a.AddressId,
                HouseBlockLotNo = a.HouseBlockLotNo,
                Street = a.Street,
                CityMunicipality = a.CityMunicipality.CityMunicipalityName,
                Barangay = a.Barangay.BarangayName,
                PurokSitio = a.PurokSitio.PurokSitioName
            }).ToListAsync();
        }
    }
}
