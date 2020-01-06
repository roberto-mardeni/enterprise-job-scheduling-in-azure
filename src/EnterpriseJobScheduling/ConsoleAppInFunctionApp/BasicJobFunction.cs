using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ConsoleAppInFunctionApp
{
    public static class BasicJobFunction
    {
        [FunctionName("BasicJobFunction")]
        public static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            new JobLibrary.BasicJob().Execute(log);
        }
    }
}
