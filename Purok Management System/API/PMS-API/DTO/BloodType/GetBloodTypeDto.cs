namespace PMS_API.DTO.BloodType
{
    public class GetBloodTypeDto
    {
        public int BloodTypeId { get; set; }
        public string BloodTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
