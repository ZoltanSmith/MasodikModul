
using static KozosResz.delegates.Delegates;

namespace KozosResz.objects
{
    public class Rendeles
    {
        public double Osszeg { get; private set; }
        public List<Termek> Termekek { get; private set; }
        public char Statusz { get; internal set; }

        public Rendeles()
        {
            Termekek = new(); // ez azért kell, hogy ne legyen null

            // ha tárolva van már termék, akkor inicializálni kell a rendeles összegét
            foreach (var termek in Termekek)
            {
                Osszeg += termek.Ar;
            }

            //Osszeg = Termekek.Sum(t => t.GetAr());
            Osszeg = Termekek.Sum(t => t.Ar);
        }

        public void AddTermek(Termek? termek)
        {
            if (termek == null)
                return;
            Termekek.Add(termek);
            Osszeg += termek.Ar;
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }

        public void Ertesites(Ertesites ertesites, Vevo vevo)
        {
            ertesites(this, vevo);
        }
    }
}
