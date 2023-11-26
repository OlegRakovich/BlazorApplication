namespace Application.Server.Local;

public class LocalStartup : StartupBase
{
    protected override void RegisterServices(IServiceCollection services)
    {
        base.RegisterServices(services);
        services.AddControllersWithViews();
        services.AddRazorPages();
    }

    protected override void ConfigureRegisteredServices(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseDeveloperExceptionPage();
        app.UseWebAssemblyDebugging();

        app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();
    }

    protected override void ConfigureEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapRazorPages();
        base.ConfigureEndpoints(endpoints);
        endpoints.MapFallbackToFile("index.html");
    }
}
