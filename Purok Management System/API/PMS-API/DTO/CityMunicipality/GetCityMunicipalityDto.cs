namespace PMS_API.DTO.CityMunicipality
{
    public class GetCityMunicipalityDto
    {
        public int CityMunicipalityId { get; set; }
        public string CityMunicipalityName { get; set; }
        public int ZipCode { get; set; }
        public bool IsActive { get; set; }
    }
}
