using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();

            /* Ky variabel perdoret per te hostuar te 
            gjitha sherbimet brenda metodes
            Prishet kur perfundon metoda main
            */
           using var scope = host.Services.CreateScope();

           var services = scope.ServiceProvider;
           try{
                var context = services.GetRequiredService<DataContext>();
                /*
                Migrate krijon nje databaze nese nuk ekziston 
                dhe nese 
                po atehere vetem dergon te dhenat qe jane nga
                 context ne databaze
       p         */
                await context.Database.MigrateAsync();
                //Perdorim await sepse metoda kthen nje task
                //await mund te perdoret vetem brenda metodave async
                await Seed.SeedData(context);
           }
           catch(Exception ex){
               var logger = services.GetRequiredService<ILogger<Program>>();
               logger.LogError(ex,"An error occured during migration");
           }
           await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
