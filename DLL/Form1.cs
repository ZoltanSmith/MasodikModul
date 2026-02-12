using KozosResz.extensions;
using KozosResz.objects;

namespace DLL_Extension
{
    public partial class Form1 : Form
    {
        Rendeles rendeles = new();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var t = rendeles.Termekek;
            // rendeles.Termekek = new List<Termek>();
            var trm = new Termek();
            bool b1 = String.IsNullOrWhiteSpace(trm.Nev);
            trm.Nev = "Asztali lámpa";
            bool b2 = String.IsNullOrWhiteSpace(trm.Nev);
            trm.Nev = "$";
            bool b3 = String.IsNullOrWhiteSpace(trm.Nev);
            //String.IsNullOrEmpty() && String.IsNullOrWhiteSpace()
            trm.Nev.Empty();
            "valami".Empty();
            t.Add(trm);
            MessageBox.Show(rendeles.ToString());

            //t = null;
            bool v = t.IsNull();
            t = null;



        }
    }
}
