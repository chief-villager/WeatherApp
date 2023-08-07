using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyWeatherApp
{
        public class Clouds
    {
        [JsonProperty("all")]
        [JsonPropertyName("all")]
        public int? All;
    }

    public class Coord
    {
        [JsonProperty("lon")]
        [JsonPropertyName("lon")]
        public double? Lon;

        [JsonProperty("lat")]
        [JsonPropertyName("lat")]
        public double? Lat;
    }

    public class Main
    {
        [JsonProperty("temp")]
        [JsonPropertyName("temp")]
        public double? Temp;

        [JsonProperty("feels_like")]
        [JsonPropertyName("feels_like")]
        public double? FeelsLike;

        [JsonProperty("temp_min")]
        [JsonPropertyName("temp_min")]
        public double? TempMin;

        [JsonProperty("temp_max")]
        [JsonPropertyName("temp_max")]
        public double? TempMax;

        [JsonProperty("pressure")]
        [JsonPropertyName("pressure")]
        public int? Pressure;

        [JsonProperty("humidity")]
        [JsonPropertyName("humidity")]
        public int? Humidity;

        [JsonProperty("sea_level")]
        [JsonPropertyName("sea_level")]
        public int? SeaLevel;

        [JsonProperty("grnd_level")]
        [JsonPropertyName("grnd_level")]
        public int? GrndLevel;
    }

    public class Rain
    {
        [JsonProperty("1h")]
        [JsonPropertyName("1h")]
        public double? _1h;
    }



    public class Sys
    {
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public int? Type;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int? Id;

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country;

        [JsonProperty("sunrise")]
        [JsonPropertyName("sunrise")]
        public int? Sunrise;

        [JsonProperty("sunset")]
        [JsonPropertyName("sunset")]
        public int? Sunset;
    }

    public class Weather
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int? Id;

        [JsonProperty("main")]
        [JsonPropertyName("main")]
        public string Main;

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description;

        [JsonProperty("icon")]
        [JsonPropertyName("icon")]
        public string Icon;
    }

    public class Wind
    {
        [JsonProperty("speed")]
        [JsonPropertyName("speed")]
        public double? Speed;

        [JsonProperty("deg")]
        [JsonPropertyName("deg")]
        public int? Deg;

        [JsonProperty("gust")]
        [JsonPropertyName("gust")]
        public double? Gust;
    }

    public class WeatherModel
    {
        [JsonProperty("coord")]
        [JsonPropertyName("coord")]
        public Coord Coord;

        [JsonProperty("weather")]
        [JsonPropertyName("weather")]
        public List<Weather> Weather;

        [JsonProperty("base")]
        [JsonPropertyName("base")]
        public string Base;

        [JsonProperty("main")]
        [JsonPropertyName("main")]
        public Main Main;

        [JsonProperty("visibility")]
        [JsonPropertyName("visibility")]
        public int? Visibility;

        [JsonProperty("wind")]
        [JsonPropertyName("wind")]
        public Wind Wind;

        [JsonProperty("rain")]
        [JsonPropertyName("rain")]
        public Rain Rain;

        [JsonProperty("clouds")]
        [JsonPropertyName("clouds")]
        public Clouds Clouds;

        [JsonProperty("dt")]
        [JsonPropertyName("dt")]
        public int? Dt;

        [JsonProperty("sys")]
        [JsonPropertyName("sys")]
        public Sys Sys;

        [JsonProperty("timezone")]
        [JsonPropertyName("timezone")]
        public int? Timezone;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int? Id;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("cod")]
        [JsonPropertyName("cod")]
        public int? Cod;
    }



    public class ApiKey{
        public string? Key;
    }
}