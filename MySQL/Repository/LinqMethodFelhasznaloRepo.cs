using MySQL.Data;

namespace MySQL.Repository
{
    internal class LinqMethodFelhasznaloRepo : IFelhasznaloRepo
    {
        public required GyakorloDbContext Conn { get; set; }

        public List<Model.Felhasznalo> GetAll()
        {
            return Conn.Felhasznalok.ToList();
        }
    }
}
