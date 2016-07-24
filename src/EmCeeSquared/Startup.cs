using Equalizer.Middleware;
using Equalizer.Middleware.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Nanophone.RegistryHost.ConsulRegistry;
using NLog.Extensions.Logging;

namespace EmCeeSquared
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .SetBasePath(env.ContentRootPath);

            Configuration = builder.Build();
        }

        private RegistryClient BuildRegistryClient(string prefixName, ConsulRegistryHostConfiguration consulConfig)
        {
            var consul = new ConsulRegistryHost(consulConfig);

            var result = new RegistryClient(prefixName, new RoundRobinAddressRouter());
            result.AddRegistryHost(consul);

            return result;
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddNLog();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            var mc2Config = new EmCeeSquaredConfiguration();
            Configuration.Bind(mc2Config);

            var consulConfig = new ConsulRegistryHostConfiguration
            {
                ConsulHost = mc2Config.Consul?.Host ?? "localhost",
                ConsulPort = mc2Config.Consul?.Port ?? 8500,
            };

            var registryClient = BuildRegistryClient(mc2Config.Router.Prefix, consulConfig);
            app.UseEqualizer(new EqualizerMiddlewareOptions { RegistryClient = registryClient, PathExclusions = new[] { "/" } });
        }
    }
}
