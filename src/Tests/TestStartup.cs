namespace Tests
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    using StartupRepro;

    public class TestStartup
    {
        private readonly Startup startUp;

        public TestStartup(IHostingEnvironment env)
        {
            startUp = new Startup(env);
            Configuration = startUp.Configuration;
        }

        public IConfigurationRoot Configuration { get; set; }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            startUp.Configure(app, env, loggerFactory);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            startUp.ConfigureServices(services);
        }

    }
}
