namespace Idojaras.Model.Weather
{
    public class OpenMeteoDailyUnits
    {
        /// <summary>
        /// "wmo code"
        /// </summary>
        public string weather_code { get; set; }
        /// <summary>
        /// "°C / °F"
        /// </summary>
        public string temperature_2m_max { get; set; }
        public string temperature_2m_min { get; set; }
    }
}