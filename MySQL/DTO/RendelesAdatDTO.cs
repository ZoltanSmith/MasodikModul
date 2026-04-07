using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL.DTO
{
    public class RendelesAdatDTO
    {
        public int RendelesId { get; set; }
        public int FelhasznaloId { get; set; }
        public string FelhasznaloNev { get; set; }
        public int TermekId { get; set; }
        public string TermekNev { get; set; }
        public int Mennyiseg { get; set; }
        public decimal Ar { get; set; }
    }
}
