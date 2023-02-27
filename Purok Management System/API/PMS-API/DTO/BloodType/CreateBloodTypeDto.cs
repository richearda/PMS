using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.BloodType
{
    public class CreateBloodTypeDto
    {
        [Required(ErrorMessage = "Blood Type name cannot be empty.")]
        public string BloodTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
