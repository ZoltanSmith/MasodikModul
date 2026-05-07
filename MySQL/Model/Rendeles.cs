using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MySQL.Model;

[Table("rendelesek")]
public partial class Rendeles : ICloneable
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
    public List<RendelesTetel> Tetelek { get; set; } = new List<RendelesTetel>();

    public Rendeles() {}

    public Rendeles(Rendeles klonozando)
    {
        Id = klonozando.Id;
        FelhasznaloId = klonozando.FelhasznaloId;
        Datum = klonozando.Datum;
        Osszesen = klonozando.Osszesen;
        Tetelek = new List<RendelesTetel>(klonozando.Tetelek.Select(t => (RendelesTetel)t.Clone()));
    }

    public object Clone()
    {
        return new Rendeles
        {
            Id = this.Id,
            FelhasznaloId = this.FelhasznaloId,
            Datum = this.Datum,
            Osszesen = this.Osszesen,
            Tetelek = new List<RendelesTetel>(this.Tetelek.Select(t => (RendelesTetel)t.Clone()))
        };
    }

    public Rendeles Klonozas()
    {
        return (Rendeles)this.MemberwiseClone();
    }


}

class MasikOsztaly
{
    // Általánosítható ha a Rendeles-t Object-re cseréljül
    public Rendeles ReflexioKlon(Rendeles klonozando)
    {
        klonozando.GetType().GetProperties().ToList().ForEach(prop =>
        {
            var ertek = prop.GetValue(klonozando); // klonozando.Id, klonozando.FelhasznaloId, klonozando.Datum, klonozando.Osszesen, klonozando.Tetelek
            string propName = prop.Name; // Id, FelhasznaloId, Datum, Osszesen, Tetelek stringként

            if (ertek is ICloneable klonozhato)
            {
                prop.SetValue(klonozando, klonozhato.Clone());
            }
            else
            {
                prop.SetValue(klonozando, ertek);
            }
        });
        return (Rendeles)klonozando.Clone();
    }
}