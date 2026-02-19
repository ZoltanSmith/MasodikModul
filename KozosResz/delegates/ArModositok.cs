using KozosResz.objects;

namespace KozosResz.delegates
{
    public static class ArModositok
    {
        public static double TizSzazalekMinusz(Termek t)
        {
            t.Ar *= 0.9;
            return t.Ar;
        }
    }
}
