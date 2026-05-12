using Microsoft.EntityFrameworkCore;
using MySQL.Model;

namespace MySQL.Data;

// Mielőtt futtatnál egy migrációt vagy scaffoldolást, győződj meg róla, hogy a Connection osztályban helyesen van beállítva a connection string a megfelelő adatbázishoz (MySQL vagy SQLite).
// Scaffoldolás vagy migráció futtatása előtt győződj meg arról, hogy a projekt könyvtárában vagy, ahol a .csproj fájl található:
// cd ProjektNev
//
// SQLite-hoz
// db first: dotnet ef dbcontext scaffold "Data Source=C:\Users\z\Downloads\SQLiteDatabaseBrowserPortable\test.db;" Microsoft.EntityFrameworkCore.Sqlite -o Model -df
// vagy MySQL-hez
// db first: dotnet ef dbcontext scaffold "server = localhost;user=zoli;port=34567;password=z;database=gyakorlo_db" MySql.EntityFrameworkCore -o Model -df
// ahol -o az output mappa paraméter, -df pedig a Data Annotations használatát jelenti a model osztályokban
//
// model first: dotnet ef migrations add MigracioNev
//              dotnet ef database update

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
        //=> optionsBuilder.UseMySQL(Connection.connectionString);
        => optionsBuilder.UseSqlite(Connection.connectionString4SQLite);

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
            entity.HasOne(e => e.Termek);
        });

        modelBuilder.Entity<Rendeles>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
            entity.HasMany(d => d.Tetelek).WithOne(p => p.Rendeles).HasForeignKey(d => d.RendelesId);
        });

        modelBuilder.Entity<Termek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TargyiEszkoz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
