using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Server.AWS
{
    public class AWSStartup : Startup
    {
        protected override void RegisterServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddCors();
        }

        protected override void ConfigureRegisteredServices(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(policy => policy
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );
        }
    }
}
