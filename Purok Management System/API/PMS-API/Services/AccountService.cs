using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.AppUser;
using PMS_API.Models;
using PMS_API.Services.Interface;
using System.Security.Cryptography;
using System.Text;

namespace PMS_API.Services
{
    public class AccountService : IAccountService
    {
        private readonly DatabaseContext _dbContext;
        private readonly ITokenService _tokenService;

        public AccountService(DatabaseContext dbContext, ITokenService tokenService)
        {
            _dbContext = dbContext;
            _tokenService = tokenService;
        }

        public async Task<UserDto> Login(LoginUserDto userDto)
        {
            //Need to modify later.
            var user = await _dbContext.AppUsers.SingleOrDefaultAsync(u => u.UserName == userDto.Username);
            using var hmac = new HMACSHA512(user.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDto.Password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) return null ;
            }
            return new UserDto
            {
                Username = user.UserName,
                Token = _tokenService.CreateToken(user)
            };           
        }

        public async Task<int> Register(RegisterUserDto userDto)
        {
            userDto.Password = "TemporaryPassword";
            using var hmac = new HMACSHA512(); 
            var user = new AppUser
            {
                UserName = userDto.Username.ToLower(),
                
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDto.Password)),
                PasswordSalt = hmac.Key,
                AppUserPerson = new Person
                {
                    FirstName = userDto.PersonDto.FirstName,
                    LastName = userDto.PersonDto.LastName,
                    MiddleName = userDto.PersonDto.MiddleName,
                    BirthPlace = userDto.PersonDto.BirthPlace,
                    BirthDate = userDto.PersonDto.BirthDate,
                    TelephoneNo = userDto.PersonDto.TelephoneNo,
                    MobileNo = userDto.PersonDto.MobileNo,
                    EmailAddress = userDto.PersonDto.EmailAddress,
                    Height = userDto.PersonDto.Height,
                    Weight = userDto.PersonDto.Weight,
                    Religion = userDto.PersonDto.Religion,
                    WithNatId = userDto.PersonDto.WithNatId,
                    WithSssGsis = userDto.PersonDto.WithSssGsis,
                    WithDriversLicense = userDto.PersonDto.WithDriversLicense,
                    IsRegisteredVoter = userDto.PersonDto.IsRegisteredVoter,
                    PrecintNo = userDto.PersonDto.PrecintNo,
                    PhotoLink = userDto.PersonDto.PhotoLink,
                    IsActive = userDto.PersonDto.IsActive,
                    GenderId = userDto.PersonDto.GenderId,
                    BloodTypeId = userDto.PersonDto.BloodTypeId,
                    CivilStatusId = userDto.PersonDto.CivilStatusId,
                    CitizenshipId = userDto.PersonDto.CitizenshipId,
                    Address = new Address
                    {
                        HouseBlockLotNo = userDto.PersonDto.Address.HouseBlockLotNo,
                        Street = userDto.PersonDto.Address.Street,
                        CityMunicipalityId = userDto.PersonDto.Address.CityMunicipalityId,
                        BarangayId = userDto.PersonDto.Address.BarangayId,
                        PurokSitioId = userDto.PersonDto.Address.PurokSitioId,
                    },
                    HealthBackground = new HealthBackground
                    {
                        IsMalnurish = userDto.PersonDto.HealthBackground.IsMalnurish,
                        IsPwd = userDto.PersonDto.HealthBackground.IsPwd,
                        PreExistingConditionId = userDto.PersonDto.HealthBackground.PreExistingConditionId,
                        VaccineTakenId = userDto.PersonDto.HealthBackground.VaccineTakenId
                    }
                },
                IsFirstLogIn = true,
                IsActive = false,
                AppUserTypeId = userDto.AppUserTypeId
                
            };
            await _dbContext.AppUsers.AddAsync(user);
            return await _dbContext.SaveChangesAsync();

           
        }


        public async Task<bool> IsUsernameExist(string username)
        {
            return await _dbContext.AppUsers.AnyAsync(u => u.UserName == username.ToLower());
        }

    }
}
