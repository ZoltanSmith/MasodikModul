using Microsoft.EntityFrameworkCore;
using MySQL.Model;

namespace MySQL.Data;

public partial class GyakorloDbContext : DbContext
{
    public GyakorloDbContext()
    {
    }

    public GyakorloDbContext(DbContextOptions<GyakorloDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Felhasznalo> Felhasznalok { get; set; }

    public virtual DbSet<Honap> Honapok { get; set; }

    public virtual DbSet<Kategoria> Kategoria { get; set; }

    public virtual DbSet<NagykerAr> NagykerArak { get; set; }

    public virtual DbSet<NoveltAr> NoveltArak { get; set; }

    public virtual DbSet<RendelesTetel> RendelesTetelek { get; set; }

    public virtual DbSet<Rendeles> Rendelesek { get; set; }

    public virtual DbSet<Termek> Termekek { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server = localhost;user=zoli;port=34567;password=z;database=gyakorlo_db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Felhasznalo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Honap>(entity =>
        {
            entity.ToView("honapok");

            entity.Property(e => e.HonapNeve).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Kategoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<NagykerAr>(entity =>
        {
            entity.ToView("nagyker_arak");
        });

        modelBuilder.Entity<NoveltAr>(entity =>
        {
            entity.ToView("novelt_arak");
        });

        modelBuilder.Entity<RendelesTetel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Rendeles>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.HasMany(d => d.RendelesTetelek).WithOne(p => p.Rendeles).HasForeignKey(d => d.RendelesId);
        });

        modelBuilder.Entity<Termek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
