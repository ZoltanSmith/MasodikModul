using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySQL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "felhasznalok",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nev = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    varos = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    ceges_email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ajanlo_id = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kategoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nev = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rendelesek",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    felhasznalo_id = table.Column<int>(type: "INTEGER", nullable: true),
                    datum = table.Column<DateTime>(type: "date", nullable: true),
                    osszesen = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "termekek",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    termek_nev = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ar = table.Column<int>(type: "INTEGER", nullable: true),
                    kategoria_id = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rendeles_tetelek",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rendeles_id = table.Column<int>(type: "INTEGER", nullable: true),
                    termek_id = table.Column<int>(type: "INTEGER", nullable: true),
                    mennyiseg = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FK_rendeles_tetelek_rendelesek_rendeles_id",
                        column: x => x.rendeles_id,
                        principalTable: "rendelesek",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_rendeles_tetelek_termekek_termek_id",
                        column: x => x.termek_id,
                        principalTable: "termekek",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_rendeles_tetelek_rendeles_id",
                table: "rendeles_tetelek",
                column: "rendeles_id");

            migrationBuilder.CreateIndex(
                name: "IX_rendeles_tetelek_termek_id",
                table: "rendeles_tetelek",
                column: "termek_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "felhasznalok");

            migrationBuilder.DropTable(
                name: "kategoria");

            migrationBuilder.DropTable(
                name: "rendeles_tetelek");

            migrationBuilder.DropTable(
                name: "rendelesek");

            migrationBuilder.DropTable(
                name: "termekek");
        }
    }
}
