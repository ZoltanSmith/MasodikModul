using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using MySQL.DTO;

namespace MySQL.Repository
{
    internal class LinqQueryRendelesRepo
    {
        public required GyakorloDbContext Context { get; set; }

        public List<RendelesNevvel> GetRendelesekNevvel()
        {
            return (from r in Context.Rendelesek.Include(r => r.Tetelek)
                    join f in Context.Felhasznalok on r.FelhasznaloId equals f.Id
                    select new RendelesNevvel
                    {
                        Id = r.Id,
                        FelhasznaloId = r.FelhasznaloId,
                        Datum = r.Datum,
                        Osszesen = r.Osszesen,
                        Tetelek = r.Tetelek,
                        FelhasznaloNev = f.Nev
                    }).ToList();
        }
    }
}
