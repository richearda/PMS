using PMS_API.DTO.Address;
using PMS_API.DTO.HealthBackground;

namespace PMS_API.DTO.Person
{
    public class GetPersonDto
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Religion { get; set; }
        public bool WithNatId { get; set; }
        public bool WithSssGsis { get; set; }
        public bool WithDriversLicense { get; set; }
        public bool IsRegisteredVoter { get; set; }
        public string PrecintNo { get; set; }
        public string PhotoLink { get; set; }
        public bool IsActive { get; set; }
        public int GenderId { get; set; }
        public string Gender { get; set; }
        public int BloodTypeId { get; set; }
        public string BloodType { get; set; }
        public int CivilStatusId { get; set; }
        public string CivilStatus { get; set; }
        public int CitizenshipId { get; set; }
        public string Citizenship { get; set; }
        public int AddressId { get; set; }
        public string HouseBlockLotNo { get; set; }
        public string Street { get; set; }
        public int CityMunicipalityId { get; set; }
        public string CityMunicipality { get; set; }
        public int BarangayId { get; set; }
        public string Barangay { get; set; }
        public int PurokSitioId { get; set; }
        public string PurokSitio { get; set; }
        public int HealthBackgroundId { get; set; }
        public bool IsMalnurish { get; set; }
        public bool IsPwd { get; set; }
        public int PreExistingConditionId { get; set; }
        public string ConditionName { get; set; }
        public int VaccineTakenId { get; set; }
        public string VaccineName { get; set; }

    }
}
