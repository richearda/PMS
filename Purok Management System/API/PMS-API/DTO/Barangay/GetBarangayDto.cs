namespace PMS_API.DTO.Barangay
{
    public class GetBarangayDto
    {
        public int BarangayId { get; set; }
        public string BarangayName { get; set; }
        public string CityMunicipalityName { get; set; }
        public int ZipCode { get; set; }
        public bool IsActive { get; set; }
    }
}
