using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using MySQL.DTO;
using MySQL.Model;
using Org.BouncyCastle.Utilities;
using System.Text;

namespace MySQL.Repository
{
    internal class LinqMethodTermekRepo
    {
        public struct TermekNevHossz { public string Name; public int Hossz; }

        public required GyakorloDbContext Context { get; set; }

        internal List<Model.Termek> GetPriceBetween5And15Th()
        {
            return Context.Termekek.Where(t => t.Ar >= 5000 && t.Ar <= 15000)
                .ToList()
                //.ForEach(t => Console.WriteLine(t))
                ;
        }

        internal List<Model.Termek> GetNameContainsVezetek()
        {
            return Context.Termekek
                .Where(t => t.TermekNev!.ToLower().Contains("vezeték"))
                .ToList();
        }

        internal List<TermekNevHossz> GetNameLength()
        {
            return Context.Termekek
                .Select(t => new TermekNevHossz()
                {
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

        internal int? LegbovebbKategoriaId()
        {
            return Context.Termekek.GroupBy(t => t.KategoriaId).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
        }

        internal List<(int? kategoriaId, double atlagar)> GetAtlagArByKategoria()
        {
            return Context.Termekek.GroupBy(t => t.KategoriaId)
                .Select(g => new { KategoriaId = g.Key, AtlagAr = g.Average(t => t.Ar) ?? 0d })
                .AsEnumerable()
                .Select(x => (kategoriaId: x.KategoriaId, atlagar: x.AtlagAr))
                .ToList();
        }
        internal List<KategoriaAtlag> GetAtlagArObjectByKategoria()
        {
            return Context.Termekek.GroupBy(t => t.KategoriaId)
                .Select(g => new KategoriaAtlag { KategoriaId = g.Key, AtlagAr = g.Average(t => t.Ar) ?? 0d })
                .ToList();
        }


        public List<DTO.Termek> GetAll()
        {
            return Context.Termekek.Join(Context.Kategoria, t => t.KategoriaId, k => k.Id, (t, k) =>
                new DTO.Termek
                {
                    Id = t.Id,
                    TermekNev = t.TermekNev,
                    Ar = t.Ar,
                    KategoriaNev = k.Nev
                }
            ).ToList();

            //TODO: async verzió
        }
    }
}
