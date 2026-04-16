using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL.DTO
{
    internal class Tetel
    {
        [Column("termek_nev")]
        public string? TermekNev { get; set; }

        [Column("ar")]
        public int? Ar { get; set; }

        [Column("mennyiseg")]
        public int? Mennyiseg { get; set; }
    }
}
