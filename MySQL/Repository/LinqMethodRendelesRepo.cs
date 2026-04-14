using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using MySQL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL.Repository
{
    internal class LinqMethodRendelesRepo
    {
        public required GyakorloDbContext Context { get; set; }

        internal List<Model.Rendeles> GetLast5()
        {
            return Context.Rendelesek
                .OrderByDescending(r => r.Datum)
                /*.Skip(5)*/
                .Take(5)
                /*.Select(r => r.Id)*/
                .ToList();
        }

        internal int GetFullIncome()
        {
            return Context.RendelesTetelek.Join(Context.Termekek, rt => rt.TermekId, t => t.Id, (rt, t) => rt.Mennyiseg * t.Ar).Sum(rt => rt) ?? 0;
        }
        internal object GetEverythingFromJoined()
        {
            return Context.RendelesTetelek.Join(Context.Termekek, rt => rt.TermekId, t => t.Id, (rt, t) => new { tetel = rt, termek = t });
        }

        public List<RendelesNevvel> GetRendelesekNevvel()
        {
            return Context.Rendelesek.Include(r => r.Tetelek)
                .Join(Context.Felhasznalok, r => r.FelhasznaloId, f => f.Id, (r, f) => new RendelesNevvel
                {
                    Id = r.Id,
                    FelhasznaloId = r.FelhasznaloId,
                    Datum = r.Datum,
                    Osszesen = r.Osszesen,
                    Tetelek = r.Tetelek,
                    FelhasznaloNev = f.Nev
                })
                .ToList();
        }
        public List<RendelesNevvel> GetRendelesekNevvelGroupJoinnal()
        {
            return Context.Rendelesek.Include(r => r.Tetelek)
                .GroupJoin(Context.Felhasznalok, r => r.FelhasznaloId, f => f.Id, (r, f) => new RendelesNevvel
                {
                    Id = r.Id,
                    FelhasznaloId = r.FelhasznaloId,
                    Datum = r.Datum,
                    Osszesen = r.Osszesen,
                    Tetelek = r.Tetelek,
                    FelhasznaloNev = f.FirstOrDefault()!.Nev ?? ""
                })
                .ToList();
        }


        internal object GetTetelek()
        {
            return Context.RendelesTetelek.Include(rt => rt.Termek).ToList();
        }
    }
}
