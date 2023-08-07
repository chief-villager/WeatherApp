using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;


namespace MyWeatherApp
{
    public class OpenWeatherClient
    {
        private readonly IHttpClientFactory _httpClientFactory;


        public OpenWeatherClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;



        }

        public async Task<WeatherModel?> GetWeatherReport(double lat, double lon)
        {
            var client = _httpClientFactory.CreateClient("OWC");
            var response = await client.GetAsync($"/data/2.5/weather?lat={lat}&lon={lon}&appid=6d5c949b5ba2da57f3a03a9e4fab657d");
            string jsonContent = await response.Content.ReadAsStringAsync();
            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(jsonContent);
            return weather;

        }
    }
}