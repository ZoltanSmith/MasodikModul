using Idojaras.Model.Geo;
using System.Text.Json;

namespace Idojaras
{
    public partial class IdojarasForm : Form
    {
        IGeocodingProvider geocodingProvider;

        public IdojarasForm()
        {
            InitializeComponent();
            geocodingProvider = new OpenMeteo();

            string city = "Budapest";

            #region Task ContinueWith
            //Task<HttpResponseMessage> task = geocodingProvider.GetCoordinatesByNameAsync(city);
            //task.ContinueWith(response =>
            //{
            //    string result = response.Result.Content.ReadAsStringAsync().Result;
            //    label1.Text = result;
            //});
            #endregion

            #region mintha szinkron lenne
            Coordinates coordinates = geocodingProvider.GetCoordinatesByName(city);
            #endregion

            #region async await
            //getCoordinates(city);
            #endregion

            //MessageBox.Show("Test");

        }

        async void getCoordinates(string city)
        {
            HttpResponseMessage response = await geocodingProvider.GetCoordinatesByNameAsync(city);
            string result = await response.Content.ReadAsStringAsync();
            label1.Text = result;
        }
    }
}
