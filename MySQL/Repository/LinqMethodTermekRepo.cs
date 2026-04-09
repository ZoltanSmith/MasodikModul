using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using MySQL.Model;
using Org.BouncyCastle.Utilities;
using System.Text;

namespace MySQL.Repository
{
    internal class LinqMethodTermekRepo
    {
        public struct TermekNevHossz { public string Name; public int Hossz; }

        public required GyakorloDbContext Context { get; set; }

        internal List<Termek> GetPriceBetween5And15Th()
        {
            return Context.Termekek.Where(t => t.Ar >= 5000 && t.Ar <= 15000)
                .ToList()
                //.ForEach(t => Console.WriteLine(t))
                ;
        }

        internal List<Termek> GetNameContainsVezetek()
        {
            return Context.Termekek
                .Where(t => t.TermekNev!.ToLower().Contains("vezeték"))
                .ToList();
        }

        internal List<TermekNevHossz> GetNameLength()
        {
            return Context.Termekek
                .Select(t => new TermekNevHossz() {
                    Name = t.TermekNev,
                    Hossz = t.TermekNev!.Length
                    //Hossz = Encoding.UTF8.GetByteCount(t.TermekNev!) // byte length
                })
                .ToList();
        }
        internal List<(string nev, int hossz)> GetNameLengthTuple()
        {
            return Context.Termekek
                .Select(t => new { Nev = t.TermekNev, Hossz = t.TermekNev!.Length })
                .AsEnumerable()
                .Select(x => (nev: x.Nev!, hossz: x.Hossz))
                .ToList();
        }
    }
}
