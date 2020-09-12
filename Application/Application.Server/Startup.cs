using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Server
{
    public abstract class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            RegisterServices(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            ConfigureRegisteredServices(app, env);

            app.UseRouting();

            app.UseEndpoints(ConfigureEndpoints);
        }

        protected abstract void RegisterServices(IServiceCollection services);

        protected abstract void ConfigureRegisteredServices(IApplicationBuilder app, IWebHostEnvironment env);

        protected virtual void ConfigureEndpoints(IEndpointRouteBuilder endpoints)
            => endpoints.MapControllers();
    }
}
