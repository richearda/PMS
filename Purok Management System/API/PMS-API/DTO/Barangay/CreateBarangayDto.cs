using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.Barangay
{
    public class CreateBarangayDto
    {
        public int barangayId { get; set; }
        [Required(ErrorMessage = "Property BarangayName must not be empty.")]
        public string BarangayName { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Property CityMunicipality must not be empty, Barangay should belong to a City or Municipality.")]
        [Range(0, int.MaxValue)]
        public int CityMunicipalityId { get; set; }
    }
}
