using System;

namespace WebASPNET_API_Lesson5.Models
{
    public class SaveRequestInfo
    {
        public Guid Id { get; set; }
        public int Temperature { get; set; }
        public int WindSpeed { get; set; }
        public int Humidity { get; set; }
        public int Feelslike { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Language { get; set; }

        public SaveRequestInfo(int temperature, int windSpeed, int humidity, int feelslike, string country, string region, string language)
        {
            Id = Guid.NewGuid();
            Temperature = temperature;
            WindSpeed = windSpeed;
            Humidity = humidity;
            Feelslike = feelslike;
            Country = country;
            Region = region;
            Language = language;
        }

        public override string ToString()
        {
            return $"In {Country} {Region} {Language} is " +
                   $"\nTemperature = {Temperature};" +
                   $"\nWindSpeed = {WindSpeed};" +
                   $"\nHumidity = {Humidity};" +
                   $"\nFeelslike = {Feelslike};";
        }
    }
}
