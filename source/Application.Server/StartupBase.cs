namespace Application.Server;

public abstract class StartupBase
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

    protected virtual void RegisterServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddMvc();
    }

    protected abstract void ConfigureRegisteredServices(IApplicationBuilder app, IWebHostEnvironment env);

    protected virtual void ConfigureEndpoints(IEndpointRouteBuilder endpoints)
        => endpoints.MapControllers();
}
