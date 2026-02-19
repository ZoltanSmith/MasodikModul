namespace EgyediKomponensek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var osszeg = 0d;
            InitializeComponent();
            termekKartya1.OnKlikk = () =>
            {
                osszeg += termekKartya1.Termek.Ar;
                osszegLabel.Text = osszeg.ToString();
                MessageBox.Show("Termék hozzáadva!");
            };
        }
    }
}
