using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras.Model.Geo
{
    internal class OpenMeteo : IGeocodingProvider
    {
        public string BaseUrl => "https://geocoding-api.open-meteo.com/v1/search";

        public HttpClient Client { get; set; }

        string param = "?name=Berlin&count=10&language=en&format=json";

        public Coordinates GetCoordinatesByName(string location)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(BaseUrl);

            Coordinates coords = new Coordinates();
            coords.City = "location";

            // szál nyílik
            Client.GetAsync(param).ContinueWith(response =>
            {
                var result = response.Result.Content.ReadAsStringAsync().Result;
                coords.City = result;

            });
            //

            return coords;
        }
    }
}
