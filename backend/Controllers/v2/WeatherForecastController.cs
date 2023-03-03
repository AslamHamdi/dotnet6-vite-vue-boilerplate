using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers.v2
{
    [EnableCors("LocalhostPolicy")]
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet(Name = nameof(GetData))]
        public WeatherForecast GetData(int id)
        {
            var testo = new WeatherForecast();
            testo.Date = DateTime.Now;
            testo.TemperatureC = 43;
            testo.Summary = "Hot lit lit";

            return testo;
        }

        [HttpGet(Name = nameof(GetData2))]
        [HttpPost(Name = nameof(GetData2))]
        public WeatherForecast GetData2(int id)
        {
            var testo = new WeatherForecast();
            testo.Date = DateTime.Now;
            testo.TemperatureC = 43;
            testo.Summary = "Panas cen cen";

            return testo;
        }
    }
}