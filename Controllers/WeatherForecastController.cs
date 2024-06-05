using ArquiteturaMSC.Model;
using ArquiteturaMSC.Model.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaMSC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IWeatherForecast _weatherForecast { get; set; }
        public WeatherForecastController(IWeatherForecast weatherForecast)
        {
            _weatherForecast = weatherForecast;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecast.Get();
        }
    }
}
