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
    }
}
