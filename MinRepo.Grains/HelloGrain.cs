using Microsoft.Extensions.Logging;
using MinRepo.Grains.Interfaces;
using System.Threading.Tasks;

namespace MinRepo.Grains
{
    public class HelloGrain : Orleans.Grain, IHello
    {
        private readonly ILogger<HelloGrain> logger;

        public HelloGrain(ILogger<HelloGrain> logger)
        {
            this.logger = logger;
        }

        Task<RecordDto[]> IHello.SayHello(string greeting)
        {
            logger.LogInformation($"\n SayHello message received: greeting = '{greeting}'");
            return Task.FromResult(new[] { new RecordDto($"\n Client said: '{greeting}', so HelloGrain says: Hello!") });
        }
    }
}
