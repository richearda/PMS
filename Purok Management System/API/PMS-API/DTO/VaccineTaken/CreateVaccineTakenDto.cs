

using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.VaccineTaken
{
    public class CreateVaccineTakenDto
    {
        [Required(ErrorMessage = "Vaccine name cannot be empty.")]
        public string VaccineName { get; set; }
        public bool IsActive { get; set; }
    }
}
