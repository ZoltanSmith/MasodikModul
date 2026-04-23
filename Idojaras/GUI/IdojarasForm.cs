using Idojaras.Model.Geo;

namespace Idojaras
{
    public partial class IdojarasForm : Form
    {
        IGeocodingProvider geocodingProvider;

        public IdojarasForm()
        {
            InitializeComponent();
            geocodingProvider = new OpenMeteo();
            Coordinates coordinates = geocodingProvider.GetCoordinatesByName("");
            MessageBox.Show("Test");
        }
    }
}
