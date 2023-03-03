using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers.v1
{
    [EnableCors("LocalhostPolicy")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class WeatherForecastController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        public string Get() => ".Net Core Web API Version 1";
    }
}