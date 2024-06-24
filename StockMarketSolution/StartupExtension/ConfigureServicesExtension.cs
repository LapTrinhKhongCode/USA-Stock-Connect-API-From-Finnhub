using Entities;
using IdentityEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServiceContracts;
using Services;

namespace StockMarketSolution.StartupExtension
{
    public static class ConfigureServicesExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration) {

            services.AddControllersWithViews();

            //add services into IoC container
            //Services
            
            services.Configure<TradingOptions>(configuration.GetSection("TradingOptions"));
            services.AddSingleton<IStocksService, StocksService>();
            services.AddSingleton<IFinnhubService, FinnhubService>();
            services.AddHttpClient();





            //thông báo add db sử dụng với sqlserver
            services.AddDbContext<Entities.ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefautConnection"));
            });
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PersonsDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False


            //thêm identity
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = true;
                options.Password.RequireDigit = false;
                options.Password.RequiredUniqueChars = 3; //Eg: AB12AB
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddUserStore<UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, Guid>>()
                .AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>();


            services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build(); //enforces authoriation policy (user must be authenticated) for all the action methods
            });

            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/Account/Login";
            });
            return services;    
        } 
    }
}
