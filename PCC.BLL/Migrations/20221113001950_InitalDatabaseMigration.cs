using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCC.BLL.Migrations
{
    /// <inheritdoc />
    public partial class InitalDatabaseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lokacije",
                columns: table => new
                {
                    LokacijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Odeljenje = table.Column<int>(type: "int", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacije", x => x.LokacijaID);
                });

            migrationBuilder.CreateTable(
                name: "Nalozi",
                columns: table => new
                {
                    NalogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Izdato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Izvrsen = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nalozi", x => x.NalogID);
                });

            migrationBuilder.CreateTable(
                name: "Racunari",
                columns: table => new
                {
                    RacunarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racunari", x => x.RacunarID);
                });

            migrationBuilder.CreateTable(
                name: "Porudzbine",
                columns: table => new
                {
                    PorudzbinaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VremePorudzbine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VremeIsporuke = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Preuzeto = table.Column<bool>(type: "bit", nullable: false),
                    LokacijaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porudzbine", x => x.PorudzbinaID);
                    table.ForeignKey(
                        name: "FK_Porudzbine_Lokacije_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zaposleni",
                columns: table => new
                {
                    ZaposleniID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LokacijaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposleni", x => x.ZaposleniID);
                    table.ForeignKey(
                        name: "FK_Zaposleni_Lokacije_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Racunar_Nalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    RacunarID = table.Column<int>(type: "int", nullable: false),
                    NalogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racunar_Nalog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racunar_Nalog_Nalozi_NalogID",
                        column: x => x.NalogID,
                        principalTable: "Nalozi",
                        principalColumn: "NalogID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Racunar_Nalog_Racunari_RacunarID",
                        column: x => x.RacunarID,
                        principalTable: "Racunari",
                        principalColumn: "RacunarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Komponente",
                columns: table => new
                {
                    KomponentaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proizvodjac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<double>(type: "float", nullable: false),
                    ProdajnaCena = table.Column<double>(type: "float", nullable: true),
                    PorudzbinaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komponente", x => x.KomponentaID);
                    table.ForeignKey(
                        name: "FK_Komponente_Porudzbine_PorudzbinaID",
                        column: x => x.PorudzbinaID,
                        principalTable: "Porudzbine",
                        principalColumn: "PorudzbinaID");
                });

            migrationBuilder.CreateTable(
                name: "Racuni",
                columns: table => new
                {
                    RacunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cena = table.Column<int>(type: "int", nullable: false),
                    Vreme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZaposleniID = table.Column<int>(type: "int", nullable: false),
                    LokacijaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racuni", x => x.RacunID);
                    table.ForeignKey(
                        name: "FK_Racuni_Lokacije_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Racuni_Zaposleni_ZaposleniID",
                        column: x => x.ZaposleniID,
                        principalTable: "Zaposleni",
                        principalColumn: "ZaposleniID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trebovanja",
                columns: table => new
                {
                    TrebovanjeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoslaoZaposleniID = table.Column<int>(type: "int", nullable: false),
                    VremeSlanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VremePreuzimanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaLokacijeLokacijaID = table.Column<int>(type: "int", nullable: false),
                    NaLokacijuLokacijaID = table.Column<int>(type: "int", nullable: false),
                    Preuzeto = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trebovanja", x => x.TrebovanjeID);
                    table.ForeignKey(
                        name: "FK_Trebovanja_Lokacije_NaLokacijuLokacijaID",
                        column: x => x.NaLokacijuLokacijaID,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trebovanja_Lokacije_SaLokacijeLokacijaID",
                        column: x => x.SaLokacijeLokacijaID,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trebovanja_Zaposleni_PoslaoZaposleniID",
                        column: x => x.PoslaoZaposleniID,
                        principalTable: "Zaposleni",
                        principalColumn: "ZaposleniID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komponenta_Porudzbine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PorudzbinaID = table.Column<int>(type: "int", nullable: false),
                    KomponentaID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komponenta_Porudzbine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komponenta_Porudzbine_Komponente_KomponentaID",
                        column: x => x.KomponentaID,
                        principalTable: "Komponente",
                        principalColumn: "KomponentaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Komponenta_Porudzbine_Porudzbine_PorudzbinaID",
                        column: x => x.PorudzbinaID,
                        principalTable: "Porudzbine",
                        principalColumn: "PorudzbinaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Racunari_Komponente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RacunarID = table.Column<int>(type: "int", nullable: false),
                    KomponentaID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racunari_Komponente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racunari_Komponente_Komponente_KomponentaID",
                        column: x => x.KomponentaID,
                        principalTable: "Komponente",
                        principalColumn: "KomponentaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Racunari_Komponente_Racunari_RacunarID",
                        column: x => x.RacunarID,
                        principalTable: "Racunari",
                        principalColumn: "RacunarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stanja",
                columns: table => new
                {
                    StanjeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LokacijaID = table.Column<int>(type: "int", nullable: false),
                    RacunarID = table.Column<int>(type: "int", nullable: true),
                    KomponentaID = table.Column<int>(type: "int", nullable: true),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stanja", x => x.StanjeID);
                    table.ForeignKey(
                        name: "FK_Stanja_Komponente_KomponentaID",
                        column: x => x.KomponentaID,
                        principalTable: "Komponente",
                        principalColumn: "KomponentaID");
                    table.ForeignKey(
                        name: "FK_Stanja_Lokacije_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacije",
                        principalColumn: "LokacijaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stanja_Racunari_RacunarID",
                        column: x => x.RacunarID,
                        principalTable: "Racunari",
                        principalColumn: "RacunarID");
                });

            migrationBuilder.CreateTable(
                name: "Racun_Komponenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    RacunID = table.Column<int>(type: "int", nullable: false),
                    KomponentaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun_Komponenta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racun_Komponenta_Komponente_KomponentaID",
                        column: x => x.KomponentaID,
                        principalTable: "Komponente",
                        principalColumn: "KomponentaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Racun_Komponenta_Racuni_RacunID",
                        column: x => x.RacunID,
                        principalTable: "Racuni",
                        principalColumn: "RacunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Racun_Racunar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    RacunID = table.Column<int>(type: "int", nullable: false),
                    RacunarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun_Racunar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racun_Racunar_Racunari_RacunarID",
                        column: x => x.RacunarID,
                        principalTable: "Racunari",
                        principalColumn: "RacunarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Racun_Racunar_Racuni_RacunID",
                        column: x => x.RacunID,
                        principalTable: "Racuni",
                        principalColumn: "RacunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trebovanje_Komponenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    TrebovanjeID = table.Column<int>(type: "int", nullable: false),
                    KomponentaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trebovanje_Komponenta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trebovanje_Komponenta_Komponente_KomponentaID",
                        column: x => x.KomponentaID,
                        principalTable: "Komponente",
                        principalColumn: "KomponentaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trebovanje_Komponenta_Trebovanja_TrebovanjeID",
                        column: x => x.TrebovanjeID,
                        principalTable: "Trebovanja",
                        principalColumn: "TrebovanjeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trebovanje_Racunar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    TrebovanjeID = table.Column<int>(type: "int", nullable: false),
                    RacunarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trebovanje_Racunar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trebovanje_Racunar_Racunari_RacunarID",
                        column: x => x.RacunarID,
                        principalTable: "Racunari",
                        principalColumn: "RacunarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trebovanje_Racunar_Trebovanja_TrebovanjeID",
                        column: x => x.TrebovanjeID,
                        principalTable: "Trebovanja",
                        principalColumn: "TrebovanjeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Komponenta_Porudzbine_KomponentaID",
                table: "Komponenta_Porudzbine",
                column: "KomponentaID");

            migrationBuilder.CreateIndex(
                name: "IX_Komponenta_Porudzbine_PorudzbinaID",
                table: "Komponenta_Porudzbine",
                column: "PorudzbinaID");

            migrationBuilder.CreateIndex(
                name: "IX_Komponente_PorudzbinaID",
                table: "Komponente",
                column: "PorudzbinaID");

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbine_LokacijaID",
                table: "Porudzbine",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_Komponenta_KomponentaID",
                table: "Racun_Komponenta",
                column: "KomponentaID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_Komponenta_RacunID",
                table: "Racun_Komponenta",
                column: "RacunID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_Racunar_RacunarID",
                table: "Racun_Racunar",
                column: "RacunarID");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_Racunar_RacunID",
                table: "Racun_Racunar",
                column: "RacunID");

            migrationBuilder.CreateIndex(
                name: "IX_Racunar_Nalog_NalogID",
                table: "Racunar_Nalog",
                column: "NalogID");

            migrationBuilder.CreateIndex(
                name: "IX_Racunar_Nalog_RacunarID",
                table: "Racunar_Nalog",
                column: "RacunarID");

            migrationBuilder.CreateIndex(
                name: "IX_Racunari_Komponente_KomponentaID",
                table: "Racunari_Komponente",
                column: "KomponentaID");

            migrationBuilder.CreateIndex(
                name: "IX_Racunari_Komponente_RacunarID",
                table: "Racunari_Komponente",
                column: "RacunarID");

            migrationBuilder.CreateIndex(
                name: "IX_Racuni_LokacijaID",
                table: "Racuni",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Racuni_ZaposleniID",
                table: "Racuni",
                column: "ZaposleniID");

            migrationBuilder.CreateIndex(
                name: "IX_Stanja_KomponentaID",
                table: "Stanja",
                column: "KomponentaID");

            migrationBuilder.CreateIndex(
                name: "IX_Stanja_LokacijaID",
                table: "Stanja",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Stanja_RacunarID",
                table: "Stanja",
                column: "RacunarID");

            migrationBuilder.CreateIndex(
                name: "IX_Trebovanja_NaLokacijuLokacijaID",
                table: "Trebovanja",
                column: "NaLokacijuLokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Trebovanja_PoslaoZaposleniID",
                table: "Trebovanja",
                column: "PoslaoZaposleniID");

            migrationBuilder.CreateIndex(
                name: "IX_Trebovanja_SaLokacijeLokacijaID",
                table: "Trebovanja",
                column: "SaLokacijeLokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Trebovanje_Komponenta_KomponentaID",
                table: "Trebovanje_Komponenta",
                column: "KomponentaID");

            migrationBuilder.CreateIndex(
                name: "IX_Trebovanje_Komponenta_TrebovanjeID",
                table: "Trebovanje_Komponenta",
                column: "TrebovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Trebovanje_Racunar_RacunarID",
                table: "Trebovanje_Racunar",
                column: "RacunarID");

            migrationBuilder.CreateIndex(
                name: "IX_Trebovanje_Racunar_TrebovanjeID",
                table: "Trebovanje_Racunar",
                column: "TrebovanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposleni_LokacijaID",
                table: "Zaposleni",
                column: "LokacijaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komponenta_Porudzbine");

            migrationBuilder.DropTable(
                name: "Racun_Komponenta");

            migrationBuilder.DropTable(
                name: "Racun_Racunar");

            migrationBuilder.DropTable(
                name: "Racunar_Nalog");

            migrationBuilder.DropTable(
                name: "Racunari_Komponente");

            migrationBuilder.DropTable(
                name: "Stanja");

            migrationBuilder.DropTable(
                name: "Trebovanje_Komponenta");

            migrationBuilder.DropTable(
                name: "Trebovanje_Racunar");

            migrationBuilder.DropTable(
                name: "Racuni");

            migrationBuilder.DropTable(
                name: "Nalozi");

            migrationBuilder.DropTable(
                name: "Komponente");

            migrationBuilder.DropTable(
                name: "Racunari");

            migrationBuilder.DropTable(
                name: "Trebovanja");

            migrationBuilder.DropTable(
                name: "Porudzbine");

            migrationBuilder.DropTable(
                name: "Zaposleni");

            migrationBuilder.DropTable(
                name: "Lokacije");
        }
    }
}
