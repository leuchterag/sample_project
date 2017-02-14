using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LAG.Services.LogType
{
    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            // Add MVC services.
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // Add MVC middlewares
            app.UseMvc();
        }
    }
}