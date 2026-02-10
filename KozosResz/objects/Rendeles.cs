
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
    }
}
