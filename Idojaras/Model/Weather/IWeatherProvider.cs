using Idojaras.Model.Geo;

namespace Idojaras.Model.Weather
{
    internal interface IWeatherProvider
    {
        /// <exception cref="Exception"></exception>
        public WeatherData GetWeather(Coordinates coords);

    }
}
