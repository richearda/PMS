namespace PMS_API.Models;

public class Person
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
    public virtual Gender? Gender { get; set; }
    public int BloodTypeId { get; set; }
    public virtual BloodType? BloodType { get; set; }
    public int CivilStatusId { get; set; }
    public virtual CivilStatus? CivilStatus { get; set; }
    public int CitizenshipId { get; set; }
    public virtual Citizenship? Citizenship { get; set; }
    public int AddressId { get; set; }
    public virtual Address? Address { get; set; }
    public int HealthBackgroundId { get; set; }
    public virtual HealthBackground? HealthBackground { get; set; }

}
