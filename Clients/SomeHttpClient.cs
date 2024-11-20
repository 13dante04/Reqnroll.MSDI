using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Reqnroll.MSDI.Clients;

public class SomeHttpClient
{
    private readonly HttpClient _httpClient;
    
    public SomeHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://google.com");
    }
    public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
    {
        return await _httpClient.PostAsync(requestUri, content);
    }
}