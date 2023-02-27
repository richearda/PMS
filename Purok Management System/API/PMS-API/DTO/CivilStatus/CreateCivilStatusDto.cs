

using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.CivilStatus
{
    public class CreateCivilStatusDto
    {
        [Required(ErrorMessage = "Civil Status name cannot be empty.")]       
        public string CivilStatusName { get; set; }
        public bool IsActive { get; set; }
    }
}
