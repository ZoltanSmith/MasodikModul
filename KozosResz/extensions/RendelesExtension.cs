using KozosResz.objects;

namespace KozosResz.extensions
{
    public static class RendelesExtension
    {
        public static void TermekModositas(this Rendeles r)
        {
            foreach (var t in r.Termekek)
            {
                t.Nev += 'x';
            }
        }

        public static string? ToString(this Rendeles r) //ellenpelda!!!
        {
            return r.Termekek[0].Nev;
        }

        public static void Lezar(Rendeles r) // nem extensionbe való
        {
            r.Statusz = 'L';
            r.Save();
        }

    }
}
