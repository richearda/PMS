namespace PMS_API.DTO.PreExistingCondition
{
    public class GetPreExistingConditionDto
    {
        public int PreExistingConditionId { get; set; }
        public string ConditionName { get; set; }
        public bool IsActive { get; set; }
    }
}
