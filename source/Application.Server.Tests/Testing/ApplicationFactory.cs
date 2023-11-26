using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Server.Tests;

internal class ApplicationFactory<TStartup>(
    Func<IServiceCollection, IServiceCollection> register
) : WebApplicationFactory<TStartup>
    where TStartup : class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
        => builder.ConfigureServices(services => register(services));
}
