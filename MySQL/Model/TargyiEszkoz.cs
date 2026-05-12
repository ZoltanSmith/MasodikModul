using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL.Model
{
    [Table("eszkozok")]
    internal class TargyiEszkoz
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("megnevezes")]
        [StringLength(100)]
        public string? Megnevezes { get; set; }

    }
}
