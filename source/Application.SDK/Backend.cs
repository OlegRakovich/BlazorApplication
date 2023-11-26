using Application.Shared;
using System.Net.Http.Json;

namespace Application.SDK;

public class Backend(WeatherForecasts weatherForecasts)
{
    public readonly WeatherForecasts WeatherForecasts = weatherForecasts;
}

public class WeatherForecasts(HttpClient Http)
{
    public async Task<WeatherForecast[]> Get()
        => await Http.GetFromJsonAsync<WeatherForecast[]>("/WeatherForecast") ?? throw UnexpectedResponse();

    static Exception UnexpectedResponse()
        => new("Unexpected response received");
}
