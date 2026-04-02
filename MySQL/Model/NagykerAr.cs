using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MySQL.Model;

[Keyless]
public partial class NagykerAr
{
    [Column("id")]
    public int Id { get; set; }

    [Column("termek_nev")]
    [StringLength(100)]
    public string? TermekNev { get; set; }

    [Column("ar")]
    [Precision(12, 1)]
    public decimal? Ar { get; set; }
}
