using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.PurokSitio
{
    public class CreatePurokSitioDto
    {
        [Required(ErrorMessage = "Purok or Sitio name cannot be empty.")]
        public string PurokSitioName { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Barangay cannot be empty, Purok or Sitio must belong to a barangay.")]
        public int BarangayId { get; set; }
    }
}
