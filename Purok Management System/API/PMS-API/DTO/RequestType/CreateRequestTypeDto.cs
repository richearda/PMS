using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.RequestType
{
    public class CreateRequestTypeDto
    {
        public int RequestTypeId { get; set; }
        [Required(ErrorMessage = "Request Type name cannot be empty.")]
        public string RequestTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
