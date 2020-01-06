using Microsoft.Extensions.Logging;
using System;

namespace JobLibrary
{
    public class BasicJob : IJob
    {
        public void Execute(ILogger log)
        {
            string name = Environment.GetEnvironmentVariable("ConsoleAppName");

            log.LogInformation($"Hello World, from {name}, at {DateTime.Now}!");
        }
    }
}
