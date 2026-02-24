using EgyediKomponensek.Components;
using KozosResz.objects;

namespace EgyediKomponensek
{
    public partial class Form1 : Form
    {
        Rendeles rendeles = new Rendeles();
        Random rnd = new Random();

        public Form1()
        {
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

            termekKartya1.Termek = new Termek
            {
                Nev = "Teszt termék 1",
                Ar = 1000,
                Aktiv = true,
            };

            for (int i = 0; i < 10; i++)
            {
                AddTermekKartya();
            }
        }

        int AddTermekKartya()
        {
            TermekKartya tk = new TermekKartya();
            tk.OnKlikk = termekKartya_OnKlikk;
            int i = flowLayoutPanel1.Controls.Count + 1;
            double v = rnd.Next(1, 100000) / 100.0;
            tk.Termek = new Termek
             {
                 Nev = "Teszt termék " + i,
                 Ar = v,
                 Aktiv = Convert.ToBoolean(rnd.Next(0, 2)),
             };
            flowLayoutPanel1.Controls.Add(tk);
            return i;
        }

        void termekKartya_OnKlikk()
        {
            var ctl = flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1];
            TermekKartya? tk = null;
            if (ctl is TermekKartya)
            {
                tk = (TermekKartya)ctl;
            }
            // le is tudjuk rövidíteni:
            //var tk = ctl is TermekKartya ? (TermekKartya)ctl : null;
            rendeles.AddTermek(tk?.Termek);
            osszegLabel.Text = rendeles.Osszeg.ToString();
            MessageBox.Show("Termék hozzáadva!");
        }
    }
}
