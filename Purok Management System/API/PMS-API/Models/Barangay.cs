namespace PMS_API.Models;

public class Barangay
{
    public int BarangayId { get; set; }
    public string BarangayName { get; set; }
    public bool IsActive { get; set; }
    public int CityMunicipalityId { get; set; }
    public virtual CityMunicipality? CityMunicipality { get; set; }


}
