using PMS_API.DTO.Barangay;

namespace PMS_API.DTO.PurokSitio
{
    public class GetPurokSitioDto
    {
        public int PurokSitioId { get; set; }
        public string PurokSitioName { get; set; }
        public bool IsActive { get; set; }
        public string BarangayName { get; set; }

    }
}
