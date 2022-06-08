using Microsoft.AspNetCore.Mvc;
using WebASPNET_API_Lesson5.Models;
using WebASPNET_API_Lesson5.Repository;

namespace WebASPNET_API_Lesson5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherstackController : ControllerBase
    {
        private readonly IWeatherstackRepository _weatherstackRepository;
        
        public WeatherstackController(IWeatherstackRepository weatherstackRepository)
        {
            _weatherstackRepository = weatherstackRepository;
        }
        [HttpGet("GetWeatherByCity")]
        public SaveRequestInfo GetWeatherByCity([FromQuery] string city)
        {
            return _weatherstackRepository.GetWeatherByCity(city);
        }
        
    }
}
