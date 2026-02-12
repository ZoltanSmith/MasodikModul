
using static KozosResz.delegates.Delegates;

namespace KozosResz.objects
{
    public class Rendeles
    {
        public List<Termek> Termekek { get; private set; }
        public char Statusz { get; internal set; }

        public Rendeles()
        {
            Termekek = new();
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
