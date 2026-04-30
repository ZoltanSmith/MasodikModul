namespace Idojaras.Model.Weather
{
    internal class OpenMeteoWeatherResponse
    {
        public OpenMeteoDailyUnits daily_units { get; set; }
        public OpenMeteoDaily daily { get; set; }
    }
}
