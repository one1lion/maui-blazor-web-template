using MauiBlazorWebTemplate.Shared;
using MauiBlazorWebTemplate.Shared.ServiceInterfaces;
using System.Net.Http.Json;

namespace MauiBlazorWebTemplate.Wasm.Services;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly HttpClient _httpClient;

    public WeatherForecastService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        return _httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }
}
