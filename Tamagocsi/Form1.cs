namespace Tamagocsi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

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
                var nev = Seged.allatNevek[rnd.Next(30)];
                var fajta = Seged.allatFajtak[rnd.Next(30)];
                allatok.Add(new Allat(nev, fajta));
            }

            allatListBox.DataSource = allatok;


            for (int i = 0; i < 18; i++)
            {
                eledelCombo.Items.Add(Seged.allatEledelek[rnd.Next(30)]);
            }
        }

        private void eledelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valasztottEledel = eledelCombo.SelectedItem;
            var valasztottAllat = allatListBox.SelectedItem as Allat;
            var valasztottAllatValue = allatListBox.SelectedValue;

            //MessageBox.Show((valasztottAllatValue == valasztottAllat) ? "true" : "false");
            var nem = rnd.Next(2) == 0 ? "nem " : String.Empty;
            MessageBox.Show($"{valasztottAllat} {nem}szereti a(z) {valasztottEledel}!");

            //var teszt = new String("{2} auhas {1}", "igen", "");
        }
    }
}
