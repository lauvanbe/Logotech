using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logotech.API.Migrations
{
    public partial class MoreModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logopedes");

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rue = table.Column<string>(maxLength: 55, nullable: false),
                    NumeroRue = table.Column<int>(nullable: false),
                    BoitePostal = table.Column<int>(nullable: true),
                    CodePostal = table.Column<int>(nullable: false),
                    Ville = table.Column<string>(maxLength: 55, nullable: false),
                    Pays = table.Column<string>(maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fonctions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fonctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lateralites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nom = table.Column<string>(maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lateralites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialisations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(maxLength: 55, nullable: false),
                    Prenom = table.Column<string>(maxLength: 55, nullable: false),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    TelFixe = table.Column<int>(nullable: true),
                    Gsm = table.Column<int>(nullable: true),
                    PersonneContact = table.Column<string>(maxLength: 55, nullable: true),
                    TelContact = table.Column<int>(nullable: true),
                    Anamnese = table.Column<string>(maxLength: 2000, nullable: false),
                    Commentaire = table.Column<string>(maxLength: 250, nullable: true),
                    PhotoUrl = table.Column<string>(nullable: true),
                    AdresseId = table.Column<int>(nullable: false),
                    LateraliteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Adresses_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Lateralites_LateraliteId",
                        column: x => x.LateraliteId,
                        principalTable: "Lateralites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Praticiens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Inami = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(maxLength: 55, nullable: false),
                    Prenom = table.Column<string>(maxLength: 55, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    TelFixe = table.Column<int>(nullable: false),
                    Gsm = table.Column<int>(nullable: false),
                    Deplacement = table.Column<bool>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    AdresseId = table.Column<int>(nullable: false),
                    SpecialisationId = table.Column<int>(nullable: false),
                    FonctionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Praticiens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Praticiens_Adresses_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Praticiens_Fonctions_FonctionId",
                        column: x => x.FonctionId,
                        principalTable: "Fonctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Praticiens_Specialisations_SpecialisationId",
                        column: x => x.SpecialisationId,
                        principalTable: "Specialisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AdresseId",
                table: "Patients",
                column: "AdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_LateraliteId",
                table: "Patients",
                column: "LateraliteId");

            migrationBuilder.CreateIndex(
                name: "IX_Praticiens_AdresseId",
                table: "Praticiens",
                column: "AdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_Praticiens_FonctionId",
                table: "Praticiens",
                column: "FonctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Praticiens_SpecialisationId",
                table: "Praticiens",
                column: "SpecialisationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Praticiens");

            migrationBuilder.DropTable(
                name: "Lateralites");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "Fonctions");

            migrationBuilder.DropTable(
                name: "Specialisations");

            migrationBuilder.CreateTable(
                name: "Logopedes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logopedes", x => x.Id);
                });
        }
    }
}
