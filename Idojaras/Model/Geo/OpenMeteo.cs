using System.Net;
using System.Text.Json;

namespace Idojaras.Model.Geo
{
    internal class OpenMeteo : IGeocodingProvider
    {
        public string BaseUrl => "https://geocoding-api.open-meteo.com/";

        public HttpClient Client { get; set; }

        string geoEndPoint = "v1/search/";
        string geoParam = "?language=en&format=json&count=1&name=";

        public OpenMeteo()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(BaseUrl);
        }

        public Task<HttpResponseMessage> GetCoordinatesByNameAsync(string location)
        {
            //Coordinates coords = new Coordinates();
            //coords.City = "location";

            // Task megoldás -> nem érdekel minket a visszatérési érték, csak a koordináták, amik majd egy másik metódusban lesznek lekérdezve
            // szál nyílik
            return Client.GetAsync(geoEndPoint + geoParam + WebUtility.UrlEncode(location));
            //    .ContinueWith(response =>
            //{
            //    var result = response.Result.Content.ReadAsStringAsync().Result;
            //    coords.City = result;

            //});
            //
        }

        public Coordinates GetCoordinatesByName(string location)
        {
            Coordinates rv = new();

            string? json = GetJson(location);
            if (json == null)
                return rv;

            OpenMeteoLocationResponse? locations = JsonSerializer.Deserialize<OpenMeteoLocationResponse>(json);
            
            if (locations.results.Count < 1)
                return rv;

            OpenMeteoLocation oml = locations.results[0];

            rv = new Coordinates()
            {
                City = oml.name,
                Latitude = oml.latitude,
                Longitude = oml.longitude
            };

            return rv;
        }

        /// <summary>
        /// ez adja az API válaszát JSON stringjét
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        string? GetJson(string location)
        {
            try
            {
                // itt várja meg a task result-ját, majd ha megvan, akkor dolgozza fel
                // mert kell a visszatérési érték a függvény miatt
                HttpResponseMessage result = GetCoordinatesByNameAsync(location).Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    return result.Content.ReadAsStringAsync().Result;
                    //rv.Ci ty = content;
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
