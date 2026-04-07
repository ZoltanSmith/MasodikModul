using Microsoft.EntityFrameworkCore;
using MySQL.Data;

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
    }
}
