namespace Vizsga3
{
    public partial class Form1 : Form
    {
        Jatekos jatekos1 = new Jatekos("1. játékos");
        Jatekos jatekos2 = new Jatekos("2. játékos");
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button gomb)
            {
                int dobott = rnd.Next(1, 7);

                switch (gomb.Name)
                {
                    case "button1":
                        jatekos1.AddPontszam(dobott, progressBar1);
                        JatekVegeVizsgalat(jatekos1);
                        break;
                    case "button2":
                        jatekos2.AddPontszam(dobott, progressBar2);
                        JatekVegeVizsgalat(jatekos2);
                        break;
                    default:
                        MessageBox.Show($"nem várt érték: {gomb.Name}");
                        break;
                }

            }
        }

        void JatekVegeVizsgalat(Jatekos j)
        {
            if (j.ElerteAHuszonegyet())
            {
                MessageBox.Show(j.Nev + " nyert!");
            }
        }
    }
}
