using KozosResz.objects;

namespace KozosResz.delegates
{
    public static class TermekAkciok
    {
        static public void Szazalekolas(Termek t, double szazalek)
        {
            t.Ar *= 1 - szazalek / 100;
        }

        static public void ArKedvezmeny(Termek t, double kedvezmeny)
        {
            t.Ar -= kedvezmeny;
        }


    }
}
