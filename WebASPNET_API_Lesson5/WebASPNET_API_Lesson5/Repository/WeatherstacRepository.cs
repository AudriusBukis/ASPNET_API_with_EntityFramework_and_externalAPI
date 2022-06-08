using Microsoft.Extensions.Logging;
using System;
using WebASPNET_API_Lesson5.Context;
using WebASPNET_API_Lesson5.Models;
using WebASPNET_API_Lesson5.Services;

namespace WebASPNET_API_Lesson5.Repository
{
    public class WeatherstacRepository : IWeatherstackRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<WeatherstacRepository> _logger;
        private readonly IHttpClientExtension _httpClient;

        public WeatherstacRepository(ApplicationDbContext context, IMapper mapper, ILogger<WeatherstacRepository> logger, IHttpClientExtension httpClient)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
            _httpClient = httpClient;
        }

        public SaveRequestInfo GetWeatherByCity(string city)
        {
            try
            {
                var responseFromWeb = _httpClient.GetInfoFromReatherstackByCityAsync(city);
                _logger.LogInformation($"Comand gets info about city={city} from the site https://weatherstack.com/ ");
                var mapData = _mapper.MapRootToSaveRequestInfo(responseFromWeb.Result);
                _context.Add(mapData);
                _context.SaveChanges();
                _logger.LogInformation($"Saved data to database\n{mapData}");
                return mapData;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return default;
            }
            
        }
       
    }
}
