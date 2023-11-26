using Application.SDK;
using Xunit;

namespace Application.Server.Tests;

public class WeatherForecastControllerTests : TestBase
{
    [Test]
    public async Task ReturnsWeatherForecastWhenAsked()
    {
        var forecasts = await Backend.WeatherForecasts.Get();
        Assert.NotEmpty(forecasts);
    }
}
