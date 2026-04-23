using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras.Model.Geo
{
    internal class OpenMeteo : IGeocodingProvider
    {
        public string BaseUrl => "https://geocoding-api.open-meteo.com/v1/search";

        public HttpClient Client { get; set; }

        string param = "?name=Berlin&count=10&language=en&format=json";

        public Task<HttpResponseMessage> GetCoordinatesByNameAsync(string location)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(BaseUrl);

            Coordinates coords = new Coordinates();
            coords.City = "location";

            // Task megoldás -> nem érdekel minket a visszatérési érték, csak a koordináták, amik majd egy másik metódusban lesznek lekérdezve
            // szál nyílik
            return Client.GetAsync(param);
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

            // itt várja meg a task result-ját, majd ha megvan, akkor dolgozza fel
            // mert kell a visszatérési érték a függvény miatt
            HttpResponseMessage result = GetCoordinatesByNameAsync(location).Result;
            if (result.StatusCode == HttpStatusCode.OK)
            {
                string content = result.Content.ReadAsStringAsync().Result;
                rv.City = content;
            }

            return rv;
        }
    }
}
