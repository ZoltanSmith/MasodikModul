using KozosResz.objects;
using static KozosResz.delegates.Delegates;
using static TermekSzerkeszto.TermekSzerkForm;

namespace TermekSzerkeszto
{
    public partial class TermekListaForm : Form
    {
        static Keszlet k = new Keszlet() { Darab = 5, Raktar = "R1" };
        Form szerkForm = new TermekSzerkForm(10, k);

        public TermekListaForm()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            szerkForm.ShowDialog();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            TermekSzerkForm sz = new TermekSzerkForm(5, k);
            // ha public-ra változtatjuk a myButton1-et, akkor elérjük így is,
            // de inkább kerüljük ezt a módot, mert a Designer fileba beleír az IDE is.
            sz.myButton1.Text = "Szerkesztés";
            sz.HatterSzin = BackColor;
            sz.Show();
            sz.FormClosed += Sz_FormClosed;
            sz.TermekSzerk += (s, e) =>
            {
                MessageBox.Show("Valami történt a szerkesztőben");
            };
            sz.Id = 123;
        }

        private void Sz_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var f = sender as TermekSzerkForm;
            var f2 = (TermekSzerkForm)sender;
            MessageBox.Show(f.Termek.Nev + " bezárva");
        }
    }
}
