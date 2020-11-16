using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Converter;
using WeatherApp.Models;
using WeatherApp.ViewModels;



namespace WeatherApp
{
    public class OpenWeatherService : ITemperatureService
    {

        private static OpenWeatherProcessor owp;
        public TemperatureModel LastTemp;

        public OpenWeatherService(string apiKey)
        {
            owp = OpenWeatherProcessor.Instance;
            owp.ApiKey = apiKey;
        }

        public async Task<TemperatureModel> GetTempAsync()
        {
            var weather = await owp.GetCurrentWeatherAsync();
            DateTime date1 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            LastTemp = new TemperatureModel();
            LastTemp.DateTime = date1.AddSeconds(weather.DateTime).ToLocalTime();
            LastTemp.Temperature = weather.Main.Temperature;

            return LastTemp;

        }




    }
}
