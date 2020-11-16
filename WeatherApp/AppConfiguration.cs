using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace WeatherApp
{
    static class AppConfiguration
    {
        static IConfiguration configuration;

        static void initConfig()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json",optional: true,reloadOnChange: true);
            builder.AddUserSecrets<MainWindow>();
            configuration = builder.Build();
        }


        public static string GetValue(string key)
        {
            if (configuration == null)
                initConfig();

            return key;
        }

    }
}
