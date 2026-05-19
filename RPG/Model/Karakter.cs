namespace RPG.Model
{
    internal class Karakter
    {
        internal string Nev { get; set; }
        internal string Kaszt { get; set; }
        internal int Ero { get; set; }
        internal int Intelligencia { get; set; }
        internal int Ugyesseg { get; set; }

        public override string? ToString()
        {
            return $"[{Kaszt}] {Nev} (Erő: {Ero}, Int: {Intelligencia}, Ügy: {Ugyesseg})";
        }

        internal string ToNiceString()
        {
            return $"[{Kaszt}] {Nev}{Environment.NewLine}" +
                $"Erő: {Ero}{Environment.NewLine}" +
                $"Int: {Intelligencia}{Environment.NewLine}" +
                $"Ügy: {Ugyesseg}";
        }
    }
}
