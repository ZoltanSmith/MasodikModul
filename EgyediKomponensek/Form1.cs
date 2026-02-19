using KozosResz.objects;

namespace EgyediKomponensek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Rendeles rendeles = new Rendeles();

            InitializeComponent();
            termekKartya1.OnKlikk = () =>
            {
                rendeles.AddTermek(termekKartya1.Termek);
                osszegLabel.Text = rendeles.Osszeg.ToString();
                MessageBox.Show("Termék hozzáadva!");
            };


            splitContainer1.Panel1Collapsed = true;
            listView1.BackColor = Color.Red;
            tableLayoutPanel1.BackColor = Color.Aqua;

        }
    }
}
