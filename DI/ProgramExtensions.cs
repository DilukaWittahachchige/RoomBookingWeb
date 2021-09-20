using EF.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DI
{
    public static class ProgramExtensions
    {
        public static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<RoomBookingContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    //TODO: Need to handle logging later
                    //var logger = services.GetRequiredService<ILogger<Program>>();
                    //logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }
    }
}
