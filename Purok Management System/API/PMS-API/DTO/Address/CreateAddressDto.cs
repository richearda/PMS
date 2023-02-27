using PMS_API.Models;
using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.Address
{
    public class CreateAddressDto
    {

        public string HouseBlockLotNo { get; set; }
        public string Street { get; set; }
        [Required(ErrorMessage = "Address must containt a city or municipality.")]
        [Range(1, int.MaxValue)]
        public int CityMunicipalityId { get; set; }
        [Required(ErrorMessage = "Address must containt a barangay.")]
        [Range(1,int.MaxValue)]
        public int BarangayId { get; set; }
        [Required(ErrorMessage = "Address must containt a purok or sitio.")]
        [Range(1, int.MaxValue)]
        public int PurokSitioId { get; set; }
    }
}
