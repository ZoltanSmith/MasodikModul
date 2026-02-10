using KozosResz.objects;

namespace KozosResz.extensions
{
    //ennek nincs értelme, mert tudjuk a forrást módosítani, de ha külső lib-ből jönne, akkor van!
    public static class TermekExtension 
    {
        public static void Inaktivalas(this Termek termek) //nagyon nem extension
        {
            termek.Aktiv = false;
        }
        public static bool GetVmi(this Termek termek)
        {
            return termek.Vmi;
        }


    }
}
