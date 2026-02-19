using KozosResz.objects;
using static KozosResz.delegates.Delegates;
using static KozosResz.delegates.TermekAkciok;
using static KozosResz.delegates.RendelesErtesitesek;
using KozosResz.delegates;

namespace Delegaltak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Vevo vevo = new Vevo(
                "Kiss Péter",
                "Budapest",
                "peter.kiss@email.ru",
                "+3612345678"
                );

            Termek termek = new Termek();
            termek.Nev = "Webkamera";
            termek.Ar = 10000;

            //singlecast
            termek.Akciozas(Szazalekolas, 10);
            termek.Akciozas(ArKedvezmeny, 100);
            termek.Akciozas(AfaElengedes, 0);
            MessageBox.Show(termek.Ar + "");

            //multicast (eseménykezelõ)
            Rendeles rendeles = new Rendeles();
            Ertesites ertesitesek = EmailErtesites;
            ertesitesek += SmsErtesites;
            ertesitesek += FelhasznaloErtesites;
            rendeles.Ertesites(ertesitesek, vevo);

            ArModositok.TizSzazalekMinusz(termek);

        }

        private void FelhasznaloErtesites(Rendeles rendeles, Vevo cimzett)
        {
            MessageBox.Show("Minden kész");
        }

        public void AfaElengedes(Termek t, double d)
        {
            Szazalekolas(t, 27);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
