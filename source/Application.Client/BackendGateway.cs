using Application.Shared;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Application.Client
{
    public class BackendGateway
    {
        readonly BackendClient Backend;

        public BackendGateway(BackendClient client)
            => Backend = client;

        public Task<WeatherForecast[]> GetForecasts()
            => Backend.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
}
