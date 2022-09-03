using Microsoft.EntityFrameworkCore.Migrations;

namespace CuidadoPorcino.App.Persistencia.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tarjetaProfesional",
                table: "Persona",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "tarjetaProfesional",
                table: "Persona");
        }
    }
}
