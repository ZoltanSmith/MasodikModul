using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using System.Collections;

namespace MySQL.Repository
{
    internal interface IFelhasznaloRepo
    {
        GyakorloDbContext Conn { get; set; }

        List<Model.Felhasznalo> GetAll();
    }
}
