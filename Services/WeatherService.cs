using Microsoft.AspNetCore.Mvc;
using MotorizedMarvels.Models;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace MotorizedMarvels.Services
{
    public class WeatherService:IWeatherService
    {
        public async Task <WeatherForecast> GetWeather()
        {
            WeatherForecast WF = new WeatherForecast();
            return WF;
        }

        


    }
}
