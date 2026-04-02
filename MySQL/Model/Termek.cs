using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MySQL.Model;

[Table("termekek")]
public partial class Termek
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("termek_nev")]
    [StringLength(100)]
    public string? TermekNev { get; set; }

    [Column("ar")]
    public int? Ar { get; set; }

    [Column("kategoria_id")]
    public int? KategoriaId { get; set; }
}
