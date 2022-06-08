using WebASPNET_API_Lesson5.Models;

namespace WebASPNET_API_Lesson5.Services
{
    public interface IMapper
    {
        public SaveRequestInfo MapRootToSaveRequestInfo(Root root);
    }
}
