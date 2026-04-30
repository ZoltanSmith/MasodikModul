using Idojaras.Model.Geo;
using System.Net;

namespace Idojaras.Model.Weather
{
    internal class OpenMeteo : IWeatherProvider
    {
        public string BaseUrl => "https://api.open-meteo.com/";
        public HttpClient Client { get; set; }

        string weatherEndPoint = "v1/forecast/";
        string weatherParam = "?daily=weather_code,temperature_2m_max,temperature_2m_min&";

        public OpenMeteo()
        {
            Client = new HttpClient
            {
                BaseAddress = new Uri(BaseUrl)
            };
        }

        //TODO: feldolgozni a response-t
        public WeatherData GetWeather(Coordinates coords)
        {
            return new WeatherData(GetJson(coords));
        }

        string? GetJson(Coordinates coords)
        {
            try
            {
                string dtString = DateTime.Now.ToString("yyyy-MM-dd");
                HttpResponseMessage result = Client.GetAsync(weatherEndPoint + weatherParam + 
                    $"start_date={dtString}&end_date={dtString}&latitude={
                        coords.Latitude.ToString().Replace(',', '.')
                    }&longitude={
                        coords.Longitude.ToString().Replace(',', '.')
                    }"
                ).Result;

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    return result.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }
}
