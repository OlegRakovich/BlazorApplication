using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

namespace Application.Client
{
    public class BackendClient : HttpClient
    {
        public BackendClient(IConfiguration settings)
            => BaseAddress = new Uri(settings["backendBaseAddress"]);
    }
}
