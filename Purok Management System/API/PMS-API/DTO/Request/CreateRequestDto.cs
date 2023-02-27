
using PMS_API.Models;
using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.Request
{
    public class CreateRequestDto
    {
        public DateTime DateRequested { get; set; }
        public DateTime PickUpDate { get; set; }
        public string Status { get; set; }
        public int RequestTypeId { get; set; }
        [Required(ErrorMessage = "Requestor cannot be empty.")]
        public int PersonId { get; set; }
    }
}
