namespace MauiBlazorWebTemplate.Shared.ServiceInterfaces;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
}
