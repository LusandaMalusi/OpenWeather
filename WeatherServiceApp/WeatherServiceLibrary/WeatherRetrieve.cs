using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherServiceLibrary
{
    class WeatherRetrieve
    {
      public static async Task<string> GetWeatherServiceAsync()
        {
            
            HttpClient httpClient = new HttpClient();

            string weather = await httpClient.GetWeatherService("                    ")
        }

    }
}
