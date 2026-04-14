using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using MySQL.Model;

namespace MySQL.Repository
{
    internal class LinqMethodFelhasznaloRepo : IFelhasznaloRepo
    {
        public required GyakorloDbContext Conn { get; set; }

        public List<Model.Felhasznalo> GetAll()
        {
            return Conn.Felhasznalok.ToList();
        }

        internal Model.Felhasznalo? GetKovacsJanos()
        {
            return Conn.Felhasznalok.Where(f => f.Nev == "Kovács János").FirstOrDefault();
            //return Conn.Felhasznalok.FirstOrDefault(f => f.Nev == "Kovács János");
        }

        internal List<string?> GetEmaillessUsers()
        {
            return Conn.Felhasznalok.Where(f => f.Email == null).Select(f => f.Nev).ToList();
        }

        internal List<Felhasznalo> GetNamesWithDoubleA()
        {
            return Conn.Felhasznalok.Where(f => EF.Functions.Like(f.Nev, "%a%a%")).ToList();
            //return Conn.Felhasznalok.Where(f => f.Nev!.Count(c => c == 'a') >= 2).ToList();
        }

        internal List<String> GetNamesWithLower()
        {
            return Conn.Felhasznalok.Select(f => f.Nev!.ToLower()).ToList();
        }

        internal long CountUsers()
        {
             return Conn.Felhasznalok.Count();
        }

        public void RunStoredProc(int param)
        {
            Conn.Felhasznalok.FromSqlRaw("EXEC ProcNeve @param", [param]);
        }

    }
}
