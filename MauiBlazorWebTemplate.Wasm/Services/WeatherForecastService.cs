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

    public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        return (await _httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json")) ?? Array.Empty<WeatherForecast>();
    }
}
