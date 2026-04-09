using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using MySQL.Model;

namespace MySQL.Repository
{
    internal class LinqQueryFelhasznaloRepo : IFelhasznaloRepo
    {
        public required GyakorloDbContext Conn { get; set; }

        public List<Model.Felhasznalo> GetAll()
        {
            return (
                from f in Conn.Felhasznalok 
                   select f
            ).ToList();
        }

        internal Model.Felhasznalo? GetKovacsJanos()
        {
            return (from f in Conn.Felhasznalok
                   where f.Nev == "Kovács János"
                   select f).FirstOrDefault();
        }

        internal List<string> GetEmaillessUsers()
        {
            return (from f in Conn.Felhasznalok
             where f.Email == null
             select f.Nev).ToList();
        }

        internal List<Felhasznalo> GetNamesWithDoubleA()
        {
            return (from f in Conn.Felhasznalok
                    where EF.Functions.Like(f.Nev, "%a%a%")
                    select f).ToList();
        }

        internal long CountUsers()
        {
            return (from f in Conn.Felhasznalok
                    select 1).Count();
        }
    }
}
