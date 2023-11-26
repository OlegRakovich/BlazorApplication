using Microsoft.Extensions.DependencyInjection;

namespace Application.Server.Tests;

public class IntegrationTestBase<Startup>
    where Startup : class
{
    readonly ApplicationFactory<Startup> Application;
    readonly IServiceProvider Provider;

    protected virtual IServiceCollection ServerServices(IServiceCollection services) => services;

    protected virtual IServiceCollection ClientServices(IServiceCollection services) => services
        .AddSingleton(_ => Application.Server.CreateClient());

    public IntegrationTestBase()
    {
        Application = new ApplicationFactory<Startup>(ServerServices);
        Provider = ClientServices(new ServiceCollection()).BuildServiceProvider();
    }

    protected Service Server<Service>()
        where Service : notnull
        => Application.Server.Services.GetRequiredService<Service>();

    protected Service Client<Service>()
        where Service : notnull
        => Provider.GetRequiredService<Service>();
}