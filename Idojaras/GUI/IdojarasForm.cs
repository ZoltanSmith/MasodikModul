using Idojaras.Model.Geo;
using Idojaras.Model.Weather;

namespace Idojaras
{
    public partial class IdojarasForm : Form
    {
        IGeocodingProvider geocodingProvider;
        IWeatherProvider weatherProvider;

        public IdojarasForm()
        {
            InitializeComponent();
            geocodingProvider = new Model.Geo.OpenMeteo();

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

            weatherProvider = new Model.Weather.OpenMeteo();
            

            //MessageBox.Show("Test");

        }

        async void getCoordinates(string city)
        {
            HttpResponseMessage response = await geocodingProvider.GetCoordinatesByNameAsync(city);
            string result = await response.Content.ReadAsStringAsync();
            WeatherText.Text = result;
        }

        private void CityText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Coordinates coordinates = geocodingProvider.GetCoordinatesByName(CityText.Text);

                    var task = new Task<WeatherData>(() =>
                    {
                        return weatherProvider.GetWeather(coordinates);
                    });
                    task.ContinueWith(task =>
                    {
                        var result = task.Result;
                        Invoke(() =>
                        {
                            WeatherText.Text = result.ToString();
                            //WeatherImg.Image = result.GetImage();
                            WeatherImg.ImageLocation = result.GetImageUrl();
                        });
                    });
                    task.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
