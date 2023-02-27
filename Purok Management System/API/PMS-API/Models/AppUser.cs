namespace PMS_API.Models
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int? PersonId { get; set; }
        public Person AppUserPerson { get; set; }
        public int AppUserTypeId { get; set; }
        public AppUserType? AppUserType { get; set; }
        public bool IsFirstLogIn { get; set; } = true;
        public bool IsActive { get; set; }
    }
}
