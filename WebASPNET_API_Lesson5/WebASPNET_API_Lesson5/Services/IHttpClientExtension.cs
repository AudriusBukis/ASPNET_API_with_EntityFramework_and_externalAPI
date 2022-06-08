using System.Threading.Tasks;
using WebASPNET_API_Lesson5.Models;

namespace WebASPNET_API_Lesson5.Services
{
    public interface IHttpClientExtension
    {
        public Task<Root> GetInfoFromReatherstackByCityAsync(string city);
    }
}
