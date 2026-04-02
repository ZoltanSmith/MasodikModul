using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MySQL.Model;

[Table("rendeles_tetelek")]
public partial class RendelesTetel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("rendeles_id")]
    public int? RendelesId { get; set; }

    [Column("termek_id")]
    public int? TermekId { get; set; }

    [Column("mennyiseg")]
    public int? Mennyiseg { get; set; }

    internal Rendeles Rendeles { get; set; }
}
