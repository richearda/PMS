using PMS_API.Services.Interface;
using PMS_API.Services;
using PMS_API.Data;
using Microsoft.EntityFrameworkCore;

namespace PMS_API.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IBarangayService, BarangayService>();
            services.AddScoped<IBloodTypeService, BloodTypeService>();
            services.AddScoped<ICitizenshipService, CitizenshipService>();
            services.AddScoped<ICityMunicipalityService, CityMunicipalityService>();
            services.AddScoped<ICivilStatusService, CivilStatusService>();
            services.AddScoped<IGenderService, GenderService>();
            services.AddScoped<IHealthBackgroundService, HealthBackgroundService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPreExistingConditionService, PreExistingConditionService>();
            services.AddScoped<IPurokSitioService, PurokSitioService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IRequestTypeService, RequestTypeService>();
            services.AddScoped<IVaccineTakenService, VaccineTakenService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAppUserTypeService, AppUserTypeService>();
        }

        public static void AddDbContext(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PMSDB")));
        }
    }
}
