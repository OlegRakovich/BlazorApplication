using Application.SDK;
using Application.Server.Local;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Server.Tests;

public class TestBase : IntegrationTestBase<LocalStartup>
{
    protected override IServiceCollection ClientServices(IServiceCollection services) => base.ClientServices(services)
        .AddSingleton<Backend>()
        .AddSingleton<WeatherForecasts>();

    protected Backend Backend
        => Client<Backend>();
}