namespace PMS_API.Models;

public class HealthBackground
{
    public int HealthBackgroundId { get; set; }
    public bool IsMalnurish { get; set; }
    public bool IsPwd { get; set; }
    public bool IsActive { get; set; }
    public int PreExistingConditionId { get; set; }
    public virtual PreExistingCondition? PreExistingCondition { get; set; }
    public int VaccineTakenId { get; set; }
    public virtual VaccineTaken? VaccineTaken { get; set; }

}
