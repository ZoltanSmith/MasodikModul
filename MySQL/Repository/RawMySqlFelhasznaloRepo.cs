using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using MySQL.Model;

namespace MySQL.Repository
{
    internal class RawMySqlFelhasznaloRepo : IFelhasznaloRepo
    {
        public required GyakorloDbContext Conn { get; set; }

        public List<Model.Felhasznalo> GetAll()
        {
             return Conn.Database.SqlQueryRaw<Felhasznalo>(
                 "SELECT * FROM felhasznalok;"
                 ).ToList();
        }

        public Felhasznalo? GetKovacsJanos()
        {
            return Conn.Database.SqlQueryRaw<Felhasznalo>(
                "SELECT * FROM felhasznalok WHERE nev = 'Kovács János'"
                ).FirstOrDefault();
        }

        public List<String> GetEmaillessUsers()
        {
            return Conn.Database.SqlQueryRaw<String>(
                "SELECT nev FROM felhasznalok WHERE email IS NULL"
                ).ToList();
        }

        public List<Felhasznalo> GetNamesWithDoubleA()
        {
            return Conn.Database.SqlQueryRaw<Felhasznalo>(
                "SELECT * FROM felhasznalok WHERE nev LIKE '%a%a%'"
                ).ToList();
        }

        internal long CountUsers()
        {
            return Conn.Database.SqlQueryRaw<int>(
                "SELECT COUNT(id) FROM felhasznalok"
                ).First();
        }
    }
}
