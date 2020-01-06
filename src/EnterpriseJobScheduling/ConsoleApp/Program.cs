using JobLibrary;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggingConfiguration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("logging.json", optional: false, reloadOnChange: true)
                .Build();

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddConfiguration(loggingConfiguration.GetSection("Logging"))
                    .AddFilter("ConsoleApp.Program", LogLevel.Debug)
                    .AddConsole();
            });

            using (loggerFactory)
            {
                var logger = loggerFactory.CreateLogger<Program>();

                new BasicJob().Execute(logger);
            };
        }
    }
}
