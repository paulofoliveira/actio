using Actio.Common.Events;
using Actio.Common.Services;

namespace Actio.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost.Create<Startup>(args)
              .UseRabbitMQ()
              .SubscribeToEvent<ActivityCreated>()
              .Build()
              .Run();
        }


    }
}
