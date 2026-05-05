using System.Text.Json;
using static Idojaras.Model.Weather.WMOCodes;

namespace Idojaras.Model.Weather
{
    internal class WeatherData
    {
        public WeatherCode code;
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

            this.code = WMOToWeatherCode(weatherResponse.daily.weather_code[0]);
            this.temperature = (weatherResponse.daily.temperature_2m_max[0] + weatherResponse.daily.temperature_2m_min[0]) / 2;
            this.temperatureUnit = weatherResponse.daily_units.temperature_2m_max ?? weatherResponse.daily_units.temperature_2m_min;
        }

        override public string ToString()
        {
            return $"Ma {temperature} {temperatureUnit} fok lesz.";
        }

        //TODO: HF többi link cseréje flaticon-ra
        internal string GetImageUrl()
        {
            switch (code)
            {
                case WeatherCode.FOG:
                    return "https://basmilius.github.io/meteocons/production/fill/svg/overcast-fog.svg";
                case WeatherCode.CLEAR:
                    return "https://basmilius.github.io/meteocons/production/fill/svg/clear-day.svg";
                case WeatherCode.CLOUDY:
                    return "https://cdn-icons-png.flaticon.com/512/1163/1163661.png";
                    //return "https://basmilius.github.io/meteocons/production/fill/svg/cloudy.svg";
                case WeatherCode.DRIZZLE:
                    return "https://basmilius.github.io/meteocons/production/fill/svg/drizzle.svg";
                case WeatherCode.RAIN:
                    return "https://basmilius.github.io/meteocons/production/fill/svg/rain.svg";
                case WeatherCode.SNOW:
                    return "https://basmilius.github.io/meteocons/production/fill/svg/snow.svg";
                case WeatherCode.STORM:
                    return "https://basmilius.github.io/meteocons/production/fill/svg/thunderstorms-day.svg";
                default:
                    return "https://i.fbcd.co/products/resized/resized-750-500/48-74312bd13c1ef6ad584c08d4a9a944ea9e2a67843ce168e0c51ed30fe57178a4.webp";
            }
        }

        //TODO: HF
        /// <summary>
        /// Resources-ból a megfelelő ikon betöltése a code alapján
        /// </summary>
        /// <returns></returns>
        public Bitmap? GetImage()
        {
            Bitmap bm = new Bitmap("");
            return bm;
        }
    }
}
