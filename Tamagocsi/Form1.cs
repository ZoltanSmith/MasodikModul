namespace Tamagocsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generalasButton_Click(object sender, EventArgs e)
        {
            List<Allat> allatok = new();
            //var allatok = new List<Allat>();

            //Allat allat = new("Bodri", "kutya");
            //allatok.Add(allat);

            //allatok.Add(new Allat("Bodri", "kutya"));
            //allatok.Count() // ez a Linq része

            for (int i = 0; i < 12; i++)
            {
                allatok.Add(new Allat($"Allat{i}", $"Fajta{i}"));
            }

        }
    }
}
