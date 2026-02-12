using static KozosResz.delegates.Delegates;

namespace KozosResz.objects
{
    public class Termek
    {

        public Termek()
        {
        
        }

        public string Nev { get; set; }
        public bool Aktiv { get; set; }
        internal bool Vmi { get; set; }
        public double Ar { get; set; }

        public void Akciozas(Akcio akcio, double ertek)
        {
            akcio(this, ertek);
        }
    }
}