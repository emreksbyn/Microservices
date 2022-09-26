using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {        
        [HttpGet]
        public string Get()
        {
            //throw new Exception("Test hatasi");
            return "";
        }
    }
}