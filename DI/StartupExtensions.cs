using BusinessServices;
using EF.Data;
using IBusinessServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;
using IDataAccess;
using DataAccess;

namespace DI
{
    public static class StartupExtensions
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static IServiceCollection AddServiceScribeCore(this IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            services.AddDbContext<RoomBookingContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //provides helpful error information in the development environment
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddControllersWithViews();
            // services.AddTransient<IEmailSender, EmailSender>();

            //DAL DI
            services.AddScoped<ICodeRepository, CodeRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IHotelBookingRepository, HotelBookingRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //BLL DI
            services.AddScoped<IRoomManagerService, RoomManagerService>();
            services.AddScoped<IRoomBookingService, RoomBookingService>();


            return services;
        }
    }
}
