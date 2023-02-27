namespace PMS_API.Models;

public class PurokSitio
{
    public int PurokSitioId { get; set; }
    public string PurokSitioName { get; set; }
    public bool IsActive { get; set; }
    public int BarangayId { get; set; }
    public virtual Barangay? Barangay { get; set; }

}
