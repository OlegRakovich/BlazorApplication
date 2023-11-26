using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Application.Client;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("app");

        builder.Services
            .AddSingleton<HttpClient>()
            .AddSingleton<BackendClient>()
            .AddSingleton<BackendGateway>();

        await builder.Build().RunAsync();
    }
}
