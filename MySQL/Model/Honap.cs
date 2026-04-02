using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MySQL.Model;

[Keyless]
public partial class Honap
{
    [Column("datum", TypeName = "date")]
    public DateTime? Datum { get; set; }

    [Column("honap_szama")]
    [StringLength(5)]
    public string? HonapSzama { get; set; }

    [Column("honap_neve")]
    [StringLength(7)]
    public string HonapNeve { get; set; } = null!;
}
