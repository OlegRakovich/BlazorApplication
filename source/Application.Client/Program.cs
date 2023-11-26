using Application.SDK;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Application.Client;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("app");

        builder.Services
            .AddSingleton<HttpClient, BackendClient>()
            .AddSingleton<Backend>()
            .AddSingleton<WeatherForecasts>();

        await builder.Build().RunAsync();
    }
}
