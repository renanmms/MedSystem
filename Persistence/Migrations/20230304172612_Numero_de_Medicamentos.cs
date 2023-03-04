using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedSystem.Persistence.Migrations
{
    public partial class Numero_de_Medicamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicamentsQuantity",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicamentsQuantity",
                table: "Patients");
        }
    }
}
