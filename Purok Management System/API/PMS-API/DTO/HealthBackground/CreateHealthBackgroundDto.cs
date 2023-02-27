using PMS_API.Models;
using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.HealthBackground
{
    public class CreateHealthBackgroundDto
    {
        public bool IsMalnurish { get; set; }
        public bool IsPwd { get; set; }
        [Range(1,int.MaxValue)]
        public int PreExistingConditionId { get; set; }
        [Range(1, int.MaxValue)]
        public int VaccineTakenId { get; set; }
        public bool IsActive { get; set; }
    }
}
