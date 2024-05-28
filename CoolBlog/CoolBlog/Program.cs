using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using System;
using System.IO;

namespace CoolBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

            Logger logger = new LoggerConfiguration()
        .ReadFrom.Configuration(configuration)
        .CreateLogger();

            logger.Information("Selam, millet!");

            Log.Logger = new LoggerConfiguration()
     .WriteTo.Console()
     .WriteTo.Debug(outputTemplate: DateTime.Now.ToString())
     .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
     .WriteTo.Seq("http://localhost:5341/")
     .MinimumLevel.Information()
     .CreateLogger();

            

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
            .ConfigureLogging(config => config.ClearProviders())
            .UseSerilog();
    }
}
