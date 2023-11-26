namespace Application.Client;

public class BackendClient : HttpClient
{
    public BackendClient(IConfiguration settings)
        => BaseAddress = new Uri(settings["backendBaseAddress"] ?? throw new ApplicationException($"backendBaseAddress setting is missing"));
}
