using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PMS_API.Models;

namespace PMS_API.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Barangay> Barangays { get; set; }
    public DbSet<BloodType> BloodTypes { get; set; }
    public DbSet<Citizenship> Citizenships { get; set; }
    public DbSet<CityMunicipality> CityMunicipalities { get; set; }
    public DbSet<CivilStatus> CivilStatuses { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<PurokSitio> PurokSitios { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<RequestType> RequesTypes { get; set; }
    public DbSet<HealthBackground> HealthBackgrounds { get; set; }
    public DbSet<PreExistingCondition> PreExistingConditions { get; set; }
    public DbSet<VaccineTaken> VaccinesTaken { get; set; }
    public DbSet<AppUserType> AppUserTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
        {
            modelBuilder.Entity(entityType.Name).ToTable(entityType.DisplayName());
        }
    }
}
