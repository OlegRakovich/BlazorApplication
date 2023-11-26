using Application.Shared;
using System.Net.Http.Json;

namespace Application.Client;

public class BackendGateway
{
    readonly BackendClient Backend;

    public BackendGateway(BackendClient client)
        => Backend = client;

    public async Task<WeatherForecast[]> GetForecasts()
        => await Backend.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast") ?? throw new Exception("Unexpected response received");
}
