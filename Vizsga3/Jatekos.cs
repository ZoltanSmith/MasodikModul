namespace Vizsga3
{
    internal class Jatekos
    {
        int Pontszam { get; set; }
        public string Nev { get; private set; }

        public Jatekos(string nev)
        {
            Nev = nev;
        }

        public void AddPontszam(int pont, ProgressBar pb)
        {
            Pontszam += pont;
            pb.Value = Pontszam;
        }

        public bool ElerteAHuszonegyet()
        {
            return Pontszam >= 21;
        }
    }
}
