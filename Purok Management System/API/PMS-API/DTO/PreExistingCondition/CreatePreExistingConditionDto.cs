using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.PreExistingCondition
{
    public class CreatePreExistingConditionDto
    {
        public int ConditionId { get; set; }
        [Required(ErrorMessage = "Condition name cannot be empty.")]
        public string ConditionName { get; set; }
        public bool IsActive { get; set; }
    }

}
