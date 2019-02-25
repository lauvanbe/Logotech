using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logotech.API.Migrations
{
    public partial class ModelsAdressePatientPhotoUserDocteur : Migration
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
                name: "Docteurs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Inami = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(maxLength: 55, nullable: false),
                    Prenom = table.Column<string>(maxLength: 55, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    TelFixe = table.Column<int>(nullable: true),
                    Gsm = table.Column<int>(nullable: true),
                    Specialisation = table.Column<string>(maxLength: 55, nullable: true),
                    Fonction = table.Column<string>(maxLength: 55, nullable: true),
                    AdresseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docteurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docteurs_Adresses_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Lateralite = table.Column<string>(maxLength: 15, nullable: false),
                    Commentaire = table.Column<string>(maxLength: 250, nullable: true),
                    AdresseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Adresses_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    Inami = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(maxLength: 55, nullable: false),
                    Prenom = table.Column<string>(maxLength: 55, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    TelFixe = table.Column<int>(nullable: true),
                    Gsm = table.Column<int>(nullable: true),
                    Deplacement = table.Column<bool>(nullable: false),
                    AdresseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Adresses_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMain = table.Column<bool>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Docteurs_AdresseId",
                table: "Docteurs",
                column: "AdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AdresseId",
                table: "Patients",
                column: "AdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PatientId",
                table: "Photos",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdresseId",
                table: "Users",
                column: "AdresseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docteurs");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Adresses");

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
