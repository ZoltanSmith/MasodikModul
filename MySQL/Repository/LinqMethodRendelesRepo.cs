using Microsoft.EntityFrameworkCore;
using MySQL.Data;
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
    }
}
