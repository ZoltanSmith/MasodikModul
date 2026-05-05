namespace Tamagocsi
{
    internal class Allat
    {
        internal string Nev { get; set; }
        public string Fajta { get; set; }

        public Allat(string nev, string fajta)
        {
            Nev = nev;
            Fajta = fajta;
        }

        public override string? ToString()
        {
            return $"{Nev} a(z) {Fajta}";
        }
    }
}