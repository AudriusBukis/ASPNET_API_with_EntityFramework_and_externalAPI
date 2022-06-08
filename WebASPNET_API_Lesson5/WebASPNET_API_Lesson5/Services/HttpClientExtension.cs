using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebASPNET_API_Lesson5.Models;

namespace WebASPNET_API_Lesson5.Services
{
    
    public class HttpClientExtension : IHttpClientExtension
    {
        private readonly IConfiguration Configuration;

        public HttpClientExtension(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public async Task<Root> GetInfoFromReatherstackByCityAsync(string city)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"http://api.weatherstack.com/current?access_key={Configuration.GetConnectionString("AccessKey")}&query={city}")
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Root>(body);
        }
    }
}

