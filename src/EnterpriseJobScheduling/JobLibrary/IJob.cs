using Microsoft.Extensions.Logging;

namespace JobLibrary
{
    public interface IJob
    {
        /// <summary>Executes this instance.</summary>
        void Execute(ILogger log);
    }
}
