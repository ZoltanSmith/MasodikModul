using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL.Model;

[Table("felhasznalok")]
public partial class Felhasznalo
{
    private string? cegesEmail;

    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nev")]
    [StringLength(100)]
    public string? Nev { get; set; }

    [Column("email")]
    [StringLength(100)]
    public string? Email { get; set; }

    [Column("varos")]
    [StringLength(50)]
    public string? Varos { get; set; }
    //public string? Varos { get => Varos ?? "ismeretlen"; set => varos = value; }

    [Column("ceges_email")]
    [StringLength(100)]
    public string? CegesEmail { get => cegesEmail ?? "ismeretlen"; set => cegesEmail = value; }

    [Column("ajanlo_id")]
    public int? AjanloId { get; set; }
}
