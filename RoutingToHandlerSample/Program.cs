using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace RoutingToHandlerSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var config = new ConfigurationBuilder()
                .Build();

            // Does not use the default builder to avoid enabling logging

            return new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseStartup<StartupWithMiddleware>();
        }
    }
}
