using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.Person;
using PMS_API.DTO.PersonDtos;
using PMS_API.Helpers;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Services
{
    public class PersonService : IPersonService
    {
        private readonly DatabaseContext _dbContext;

        public PersonService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Person> CreatePersonAsync(CreatePersonDto person)
        {
            ///Map Person Dto to Person Model
            var personModel = new Person
            {
                FirstName = person.FirstName,
                MiddleName = person.MiddleName,
                LastName = person.LastName,
                BirthPlace = person.BirthPlace,
                BirthDate = person.BirthDate,
                TelephoneNo = person.TelephoneNo,
                MobileNo = person.MobileNo,
                EmailAddress = person.EmailAddress,
                Height = person.Height,
                Weight = person.Weight,
                Religion = person.Religion,
                WithNatId = person.WithNatId,
                WithSssGsis = person.WithSssGsis,
                WithDriversLicense = person.WithDriversLicense,
                IsRegisteredVoter = person.IsRegisteredVoter,
                PrecintNo = person.PrecintNo,
                PhotoLink = person.PhotoLink,
                IsActive = person.IsActive,
                GenderId = person.GenderId,
                BloodTypeId = person.BloodTypeId,
                CivilStatusId = person.CivilStatusId,
                CitizenshipId = person.CitizenshipId,
                Address = new Address
                {
                    HouseBlockLotNo = person.Address.HouseBlockLotNo,
                    Street = person.Address.Street,
                    CityMunicipalityId = person.Address.CityMunicipalityId,
                    BarangayId = person.Address.BarangayId,
                    PurokSitioId = person.Address.PurokSitioId
                },
                HealthBackground = new HealthBackground
                {
                    IsMalnurish = person.HealthBackground.IsMalnurish,
                    IsPwd = person.HealthBackground.IsPwd,
                    PreExistingConditionId = person.HealthBackground.PreExistingConditionId,
                    VaccineTakenId = person.HealthBackground.VaccineTakenId,
                }
            };
            await _dbContext.People.AddAsync(personModel);
            await _dbContext.SaveChangesAsync();
            return personModel;
        }

        public async Task<Person> DeletePersonAsync(int Id)
        {
            var toDelete = await _dbContext.People.Where(p => p.PersonId == Id).FirstOrDefaultAsync();
            if (toDelete != null)
            {
                _dbContext.People.Remove(toDelete);
                await _dbContext.SaveChangesAsync();
            }
            return toDelete;
        }
 
        public async Task<GetPersonDto> GetPersonAsync(int Id)
        {
            return await _dbContext.People.Where(p => p.PersonId == Id).Select(p => new GetPersonDto
            {
                PersonId = p.PersonId,
                FirstName = p.FirstName, 
                LastName = p.LastName,
                MiddleName = p.MiddleName,
                BirthPlace = p.BirthPlace,
                BirthDate = p.BirthDate,
                TelephoneNo = p.TelephoneNo,
                MobileNo = p.MobileNo,
                EmailAddress = p.EmailAddress,
                Height = p.Height,
                Weight = p.Weight,
                Religion = p.Religion,
                WithNatId = p.WithNatId,
                WithSssGsis = p.WithSssGsis,
                WithDriversLicense = p.WithDriversLicense,
                IsRegisteredVoter = p.IsRegisteredVoter,
                PrecintNo = p.PrecintNo,
                PhotoLink = p.PhotoLink,
                Gender = p.Gender.GenderName,
                BloodType = p.BloodType.BloodTypeName,
                CivilStatus = p.CivilStatus.CivilStatusName,
                Citizenship = p.Citizenship.CitizenshipName,
                IsActive = p.IsActive
            }).FirstOrDefaultAsync();
        }

        public async Task<Person> UpdatePersonAsync(Person person)
        {
            _dbContext.Entry(person).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return person;
        }

        public async Task<PagedList<GetPersonDto>> GetAllPersonsAsync(PersonParams userParams)
        {

            var persons = _dbContext.People.Include(p => p.Address).ThenInclude(a => a.Barangay)
             .Where(b => b.Address.Barangay.BarangayName == userParams.BarangayName).Select(p => new GetPersonDto
             {
                 PersonId = p.PersonId,
                 FirstName = p.FirstName,
                 LastName = p.LastName,
                 MiddleName = p.MiddleName,
                 BirthPlace = p.BirthPlace,
                 BirthDate = p.BirthDate,
                 TelephoneNo = p.TelephoneNo,
                 MobileNo = p.MobileNo,
                 EmailAddress = p.EmailAddress,
                 Height = p.Height,
                 Weight = p.Weight,
                 Religion = p.Religion,
                 WithNatId = p.WithNatId,
                 WithSssGsis = p.WithSssGsis,
                 WithDriversLicense = p.WithDriversLicense,
                 IsRegisteredVoter = p.IsRegisteredVoter,
                 PrecintNo = p.PrecintNo,
                 PhotoLink = p.PhotoLink,
                 Gender = p.Gender.GenderName,
                 BloodType = p.BloodType.BloodTypeName,
                 CivilStatus = p.CivilStatus.CivilStatusName,
                 Citizenship = p.Citizenship.CitizenshipName,
                 AddressId = p.AddressId,
                 HouseBlockLotNo = p.Address.HouseBlockLotNo,
                 Street = p.Address.Street,
                 CityMunicipalityId = p.Address.CityMunicipalityId,
                 CityMunicipality = p.Address.CityMunicipality.CityMunicipalityName,
                 BarangayId = p.Address.BarangayId,
                 Barangay = p.Address.Barangay.BarangayName,
                 PurokSitioId = p.Address.PurokSitioId,
                 PurokSitio = p.Address.PurokSitio.PurokSitioName,
                 HealthBackgroundId = p.HealthBackgroundId,
                 IsMalnurish = p.HealthBackground.IsMalnurish,
                 IsPwd = p.HealthBackground.IsPwd,
                 PreExistingConditionId = p.HealthBackground.PreExistingConditionId,
                 ConditionName = p.HealthBackground.PreExistingCondition.ConditionName,
                 VaccineTakenId = p.HealthBackground.VaccineTakenId,
                 VaccineName = p.HealthBackground.VaccineTaken.VaccineName,
                 IsActive = p.IsActive
             }).AsQueryable();
            return await PagedList<GetPersonDto>.CreateAsync(persons, userParams.PageNumber, userParams.PageSize);
        }

    }
}
