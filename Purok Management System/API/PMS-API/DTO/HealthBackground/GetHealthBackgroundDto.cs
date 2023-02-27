using PMS_API.DTO.PreExistingCondition;
using PMS_API.DTO.VaccineTaken;

namespace PMS_API.DTO.HealthBackground
{
    public class GetHealthBackgroundDto
    {
        public int HealthBackgroundId { get; set; }
        public bool IsMalnurish { get; set; }
        public bool IsPwd { get; set; }
        public GetPreExistingConditionDto PreExistingCondition { get; set; }
        public GetVaccineTakenDto VaccineTaken { get; set; }
        public bool IsActive { get; set; }
    }
}
