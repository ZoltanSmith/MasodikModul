using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace MySQL.Repository
{
    internal interface IRendelesRepo
    {
        DbContext Conn { get; set; }

        IEnumerable GetRendelesWithAllData();
    }
}
