using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectDAW.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adrese",
                columns: table => new
                {
                    IdAdresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tara = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAngajat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adrese", x => x.IdAdresa);
                });

            migrationBuilder.CreateTable(
                name: "Departamente",
                columns: table => new
                {
                    IdDepartament = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeDepartament = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamente", x => x.IdDepartament);
                });

            migrationBuilder.CreateTable(
                name: "Proiecte",
                columns: table => new
                {
                    IdProiect = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetaliiProiect = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proiecte", x => x.IdProiect);
                });

            migrationBuilder.CreateTable(
                name: "angajati",
                columns: table => new
                {
                    IdAngajat = table.Column<int>(type: "int", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salariu = table.Column<int>(type: "int", nullable: false),
                    ForeignKeyDepartamente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_angajati", x => x.IdAngajat);
                    table.ForeignKey(
                        name: "FK_angajati_Adrese_IdAngajat",
                        column: x => x.IdAngajat,
                        principalTable: "Adrese",
                        principalColumn: "IdAdresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_angajati_Departamente_ForeignKeyDepartamente",
                        column: x => x.ForeignKeyDepartamente,
                        principalTable: "Departamente",
                        principalColumn: "IdDepartament",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProiecteAngajati",
                columns: table => new
                {
                    IdProiect = table.Column<int>(type: "int", nullable: false),
                    IdAngajat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProiecteAngajati", x => new { x.IdProiect, x.IdAngajat });
                    table.ForeignKey(
                        name: "FK_ProiecteAngajati_angajati_IdAngajat",
                        column: x => x.IdAngajat,
                        principalTable: "angajati",
                        principalColumn: "IdAngajat",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProiecteAngajati_Proiecte_IdProiect",
                        column: x => x.IdProiect,
                        principalTable: "Proiecte",
                        principalColumn: "IdProiect",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_angajati_ForeignKeyDepartamente",
                table: "angajati",
                column: "ForeignKeyDepartamente");

            migrationBuilder.CreateIndex(
                name: "IX_ProiecteAngajati_IdAngajat",
                table: "ProiecteAngajati",
                column: "IdAngajat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProiecteAngajati");

            migrationBuilder.DropTable(
                name: "angajati");

            migrationBuilder.DropTable(
                name: "Proiecte");

            migrationBuilder.DropTable(
                name: "Adrese");

            migrationBuilder.DropTable(
                name: "Departamente");
        }
    }
}
