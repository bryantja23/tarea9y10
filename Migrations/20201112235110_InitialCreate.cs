using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ej9.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Iglesias",
                columns: table => new
                {
                    IglesiaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sexo = table.Column<string>(type: "TEXT", nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Paísnacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Ciudadnacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Paísactual = table.Column<string>(type: "TEXT", nullable: true),
                    Ciudadactual = table.Column<string>(type: "TEXT", nullable: true),
                    Dirección = table.Column<string>(type: "TEXT", nullable: true),
                    Teléfono = table.Column<int>(type: "INTEGER", nullable: false),
                    Celular = table.Column<int>(type: "INTEGER", nullable: false),
                    Correoelectrónico = table.Column<string>(type: "TEXT", nullable: true),
                    Tipoidenti = table.Column<string>(type: "TEXT", nullable: true),
                    Documentoidentidad = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iglesias", x => x.IglesiaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iglesias");
        }
    }
}
