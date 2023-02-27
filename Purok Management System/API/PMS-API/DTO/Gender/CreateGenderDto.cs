

using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.Gender
{
    public class CreateGenderDto
    {
        [Required(ErrorMessage = "Gender name cannot be empty.")]
        public string GenderName { get; set; }
        public bool IsActive { get; set; }
    }
}
