using MotorizedMarvels.Models;

namespace MotorizedMarvels.Services
{
    public interface IWeatherService
    {
         Task<WeatherForecast> GetWeather();
    }
}
