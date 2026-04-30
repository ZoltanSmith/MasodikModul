using System.Text.Json;

namespace Idojaras.Model.Weather
{
    internal class WeatherData
    {
        public int wmoCode;
        //TODO: wmo_code -> enum
        //TODO: wmo_code alapján ikon megjelenítése

        public float temperature;
        public string temperatureUnit;

        public WeatherData(string? json)
        {
            if (json == null)
                throw new Exception("json is null");

            OpenMeteoWeatherResponse? weatherResponse = JsonSerializer.Deserialize<OpenMeteoWeatherResponse>(json);

            if (weatherResponse == null) { 
                throw new Exception("weatherResponse is null");
            }

            if (weatherResponse.daily.weather_code.Count() < 1)
            {
                throw new Exception("weatherResponse is empty");
            }

            this.wmoCode = weatherResponse.daily.weather_code[0];
            this.temperature = (weatherResponse.daily.temperature_2m_max[0] + weatherResponse.daily.temperature_2m_min[0]) / 2;
            this.temperatureUnit = weatherResponse.daily_units.temperature_2m_max ?? weatherResponse.daily_units.temperature_2m_min;
        }
    }
}
