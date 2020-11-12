using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrkvaProjekt.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonirajKategorije",
                columns: table => new
                {
                    DonirajKategorijeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonirajKategorije", x => x.DonirajKategorijeID);
                });

            migrationBuilder.CreateTable(
                name: "Novosti",
                columns: table => new
                {
                    NovostiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    DatumObjavljivanja = table.Column<DateTime>(nullable: false),
                    Naslov = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novosti", x => x.NovostiID);
                });

            migrationBuilder.CreateTable(
                name: "ObavjestenjaKategorije",
                columns: table => new
                {
                    ObavjestenjaKategorijeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObavjestenjaKategorije", x => x.ObavjestenjaKategorijeID);
                });

            migrationBuilder.CreateTable(
                name: "ObrediKategorije",
                columns: table => new
                {
                    ObrediKategorijeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObrediKategorije", x => x.ObrediKategorijeID);
                });

            migrationBuilder.CreateTable(
                name: "NovostiSlike",
                columns: table => new
                {
                    NovostiSlikeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NovostiID = table.Column<int>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovostiSlike", x => x.NovostiSlikeID);
                    table.ForeignKey(
                        name: "FK_NovostiSlike_Novosti_NovostiID",
                        column: x => x.NovostiID,
                        principalTable: "Novosti",
                        principalColumn: "NovostiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Obavjestenja",
                columns: table => new
                {
                    ObavjestenjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    DatumObjavljivanja = table.Column<DateTime>(nullable: false),
                    Naslov = table.Column<string>(nullable: true),
                    ObavjestenjaKategorijeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavjestenja", x => x.ObavjestenjaID);
                    table.ForeignKey(
                        name: "FK_Obavjestenja_ObavjestenjaKategorije_ObavjestenjaKategorijeID",
                        column: x => x.ObavjestenjaKategorijeID,
                        principalTable: "ObavjestenjaKategorije",
                        principalColumn: "ObavjestenjaKategorijeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObavjestenjaSlike",
                columns: table => new
                {
                    ObavjestenjaSlikeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObavjestenjaID = table.Column<int>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObavjestenjaSlike", x => x.ObavjestenjaSlikeID);
                    table.ForeignKey(
                        name: "FK_ObavjestenjaSlike_Obavjestenja_ObavjestenjaID",
                        column: x => x.ObavjestenjaID,
                        principalTable: "Obavjestenja",
                        principalColumn: "ObavjestenjaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NovostiSlike_NovostiID",
                table: "NovostiSlike",
                column: "NovostiID");

            migrationBuilder.CreateIndex(
                name: "IX_Obavjestenja_ObavjestenjaKategorijeID",
                table: "Obavjestenja",
                column: "ObavjestenjaKategorijeID");

            migrationBuilder.CreateIndex(
                name: "IX_ObavjestenjaSlike_ObavjestenjaID",
                table: "ObavjestenjaSlike",
                column: "ObavjestenjaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonirajKategorije");

            migrationBuilder.DropTable(
                name: "NovostiSlike");

            migrationBuilder.DropTable(
                name: "ObavjestenjaSlike");

            migrationBuilder.DropTable(
                name: "ObrediKategorije");

            migrationBuilder.DropTable(
                name: "Novosti");

            migrationBuilder.DropTable(
                name: "Obavjestenja");

            migrationBuilder.DropTable(
                name: "ObavjestenjaKategorije");
        }
    }
}
