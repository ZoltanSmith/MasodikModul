using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL.Model;

[Table("rendeles_tetelek")]
public partial class RendelesTetel : ICloneable
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

    internal Termek Termek { get; set; }

    public RendelesTetel() { }

    public RendelesTetel(Termek t, Rendeles r, int menny)
    {
        this.TermekId = t.Id;
        this.RendelesId = r.Id;
        this.Mennyiseg = menny;
    }


    public object Clone()
    {
        return new RendelesTetel
        {
            Id = this.Id,
            RendelesId = this.RendelesId,
            TermekId = this.TermekId,
            Mennyiseg = this.Mennyiseg,
            Termek = this.Termek,
            // Note: Rendeles klónozásakor körkörörös hivatkozás léphet fel, ezért csak a referencia másolása javasolt.
            //Rendeles = this.Rendeles != null ? (Rendeles)this.Rendeles.Clone() : null,
            Rendeles = this.Rendeles
        };
    }

}
