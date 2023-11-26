﻿namespace Application.Shared;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public required string Summary { get; init; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
