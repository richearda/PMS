namespace PMS_API.DTO.VaccineTaken
{
    public class GetVaccineTakenDto
    {
        public int VaccineTakenId { get; set; }
        public string VaccineName { get; set; }
        public bool IsActive { get; set; }
    }
}
