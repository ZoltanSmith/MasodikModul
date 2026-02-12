namespace KozosResz.objects
{
    public class Vevo
    {
        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public string Email { get; private set; }
        public string Telefon { get; private set; }
        public Vevo(string nev, string cim, string email, string telefon)
        {
            Nev = nev;
            Cim = cim;
            Email = email;
            Telefon = telefon;
        }
    }
}
