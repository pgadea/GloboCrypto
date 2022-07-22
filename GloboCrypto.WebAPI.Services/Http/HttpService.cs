using System.Net.Http.Json;

namespace GloboCrypto.WebAPI.Services.Http
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient HttpClient;

        public HttpService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public Task<T> GetAsync<T>(string url)
        {
            return HttpClient.GetFromJsonAsync<T>(url);
        }

    }
}
