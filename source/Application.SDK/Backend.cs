namespace Application.SDK;

public class Backend(WeatherForecasts weatherForecasts)
{
    public readonly WeatherForecasts WeatherForecasts = weatherForecasts;
}
