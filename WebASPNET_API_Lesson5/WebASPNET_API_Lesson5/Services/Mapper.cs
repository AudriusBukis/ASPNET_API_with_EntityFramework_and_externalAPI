using WebASPNET_API_Lesson5.Models;

namespace WebASPNET_API_Lesson5.Services
{
    public class Mapper : IMapper
    {
        public SaveRequestInfo MapRootToSaveRequestInfo(Root root)
        {
            return new SaveRequestInfo(root.Current.Temperature, 
                                       root.Current.WindSpeed,
                                       root.Current.Humidity,
                                       root.Current.Feelslike,
                                       root.Location.Country,
                                       root.Location.Region,
                                       root.Request.Language);
        }
    }
}
