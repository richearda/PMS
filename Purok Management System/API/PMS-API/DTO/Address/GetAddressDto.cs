using PMS_API.DTO.Barangay;
using PMS_API.DTO.PurokSitio;

namespace PMS_API.DTO.Address
{
    public class GetAddressDto
    {
        public int AddressId { get; set; }
        public string HouseBlockLotNo { get; set; }
        public string Street { get; set; }
        public string CityMunicipality { get; set; }
        public string Barangay { get; set; }
        public string PurokSitio { get; set; }
    }
}
