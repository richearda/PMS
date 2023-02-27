using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.CityMunicipality
{
    public class CreateCityMunicipalityDto
    {
        [Required(ErrorMessage = "City or Municipality name cannot be empty.")]
        public string CityMunicipalityName { get; set; }
        [Required]
        [Range(1000,9999)]
        [MaxLength(4, ErrorMessage = "Zip code length should be 4 numbers.")]
        public int ZipCode { get; set; }
        public bool IsActive { get; set; }
    }
}
