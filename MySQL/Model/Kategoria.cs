using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MySQL.Model;

[Table("kategoria")]
public partial class Kategoria
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nev")]
    [StringLength(50)]
    public string? Nev { get; set; }
}
