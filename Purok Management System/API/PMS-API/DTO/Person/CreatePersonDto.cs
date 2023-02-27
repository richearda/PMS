
using PMS_API.DTO.Address;
using PMS_API.DTO.HealthBackground;
using PMS_API.Models;
using System.ComponentModel.DataAnnotations;

namespace PMS_API.DTO.PersonDtos
{
    public class CreatePersonDto
    {
        [Required(ErrorMessage = "First Name cannot be empty.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name cannot be empty.")]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string TelephoneNo { get; set; }
        [Phone]
        public string MobileNo { get; set; }
        [EmailAddress]
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
        [Required(ErrorMessage = " Please select your gender")]
        public int GenderId { get; set; }
        public int BloodTypeId { get; set; }
        public int CivilStatusId { get; set; }
        public int CitizenshipId { get; set; }
        public CreateHealthBackgroundDto HealthBackground { get; set; }
        public CreateAddressDto Address { get; set; }
    }
}
