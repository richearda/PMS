namespace PMS_API.Models;

public class Address
{
    public int AddressId { get; set; }
    public string HouseBlockLotNo { get; set; }
    public string Street { get; set; }
    public int CityMunicipalityId { get; set; }
    //Pending Migration for FK Configuration
    public virtual CityMunicipality CityMunicipality { get; set; }
    public int BarangayId { get; set; }
    public virtual Barangay? Barangay { get; set; }
    public int PurokSitioId { get; set; }
    public virtual PurokSitio? PurokSitio { get; set; }
}
