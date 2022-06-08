using WebASPNET_API_Lesson5.Models;

namespace WebASPNET_API_Lesson5.Repository
{
    public interface IWeatherstackRepository
    {
        public SaveRequestInfo GetWeatherByCity(string city);
        
    }
}
