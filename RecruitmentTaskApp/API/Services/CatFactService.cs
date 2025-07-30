using API.DTO;
using API.Interfaces;

namespace API.Services;


public class CatFactService : ICatFactService
{
    private readonly HttpClient _httpClient;
    public CatFactService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CatFactResponse?> GetCatFactAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("https://catfact.ninja/fact");

            if (!response.IsSuccessStatusCode)
                return null;

            var content = await response.Content.ReadFromJsonAsync<CatFactResponse>();
            return content;
        }
        catch (Exception)
        {
            return null;
        }
    }
}


