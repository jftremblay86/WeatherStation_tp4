using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace WeatherApp
{
    public static class AppConfiguration
    {
        private static IConfiguration configuration;

        private static void initConfig()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json",optional: true,reloadOnChange: true);
            builder.AddUserSecrets<MainWindow>();
            configuration = builder.Build();

          
        }


        public static string GetValue(string V)
        {
            if (configuration == null)
                initConfig();

            return configuration[V];
        }

    }
}
