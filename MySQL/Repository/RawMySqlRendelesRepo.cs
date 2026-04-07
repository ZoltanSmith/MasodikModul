using Microsoft.EntityFrameworkCore;
using MySQL.DTO;
using System.Collections;

namespace MySQL.Repository
{
    internal class RawMySqlRendelesRepo : IRendelesRepo
    {
        public required DbContext Conn { get; set; }

        public IEnumerable GetRendelesWithAllData()
        {
            return Conn.Database.SqlQueryRaw<RendelesAdatDTO>(
                "select *" +
                " from rendelesek" +
                " join rendeles_tetelek on (rendelesek.id = rendeles_tetelek.rendeles_id)" +
                " join termekek on (termekek.id = rendeles_tetelek.termek_id)" +
                " join felhasznalok on (felhasznalok.id = rendelesek.felhasznalo_id);"
                ).ToList();

        }
    }
}
