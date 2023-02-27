

using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.Citizenship
{
    public class CreateCitizenshipDto
    {
        [Required(ErrorMessage = "Citizenship name cannot be empty.")]       
        public string CitizenshipName { get; set; }
        public bool IsActive { get; set; }
    }
}
