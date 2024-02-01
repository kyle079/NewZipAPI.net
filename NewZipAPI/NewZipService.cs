using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace NewZipAPI;

public class NewZipService : INewZipService, IDisposable
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;
    private readonly string _apiKey;

    public NewZipService(string baseUrl = "https://api.newzip.com/leads/v1", string apiKey = "demo",
        HttpClient? http = null)
    {
        _http = http ?? new HttpClient();
        _baseUrl = baseUrl;
        _apiKey = apiKey;
    }

    public NewZipService(IHttpClientFactory httpClientFactory, IConfiguration config)
    {
        _http = httpClientFactory.CreateClient("NewZip");
        _baseUrl = config["NewZip:BaseUrl"] ?? "https://api.newzip.com/leads/v1";
        _apiKey = config["NewZip:ApiKey"] ?? "demo";
    }

    private Task<HttpClient> CreateClientAsync(HttpClient client)
    {
        client.DefaultRequestHeaders.Add("X-API-KEY", _apiKey);
        return Task.FromResult(client);
    }

    public async Task<NewZipResponse> SubmitLeadAsync(NewZipLeadRequest request)
    {
        try
        {
            var client = await CreateClientAsync(_http);
            var response = await client.PostAsJsonAsync($"{_baseUrl}/submit", request);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<NewZipResponse>();
                if (result == null) throw new Exception("Failed to deserialize response from NewZip");
                if (!result.Success)
                    throw new Exception($"Request was successful, but NewZip returned an error: {result.Message}");
                return result;
            }
            var error = await response.Content.ReadAsStringAsync();
            throw new Exception($"Failed to submit request to NewZip: {response.StatusCode} - {error}");
        }
        catch (Exception e)
        {
            throw new Exception("Failed to submit request to NewZip", e);
        }
    }

    public void Dispose()
    {
        _http.Dispose();
    }
}