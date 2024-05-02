using Microsoft.AspNetCore.Mvc;
using MotorizedMarvels.Models;
using MotorizedMarvels.Services;

namespace MotorizedMarvels.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
          "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        [HttpGet]
        [Route ("Weather")]
        public async Task <IActionResult> Weather()
        {
           var getweather =await _weatherService.GetWeather();
            return Ok (getweather);
        }
        
    }
}