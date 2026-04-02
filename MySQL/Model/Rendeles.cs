using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MySQL.Model;

[Table("rendelesek")]
public partial class Rendeles
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("felhasznalo_id")]
    public int? FelhasznaloId { get; set; }

    [Column("datum", TypeName = "date")]
    public DateTime? Datum { get; set; }

    [Column("osszesen")]
    [Precision(10, 2)]
    public decimal? Osszesen { get; set; }

    [NotMapped]
    public List<RendelesTetel> RendelesTetelek { get; set; } = new List<RendelesTetel>();
}
