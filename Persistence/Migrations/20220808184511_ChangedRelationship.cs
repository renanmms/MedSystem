using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedSystem.Persistence.Migrations
{
    public partial class ChangedRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicaments_Patients_PatientId",
                table: "Medicaments");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicaments_Patients_PatientId",
                table: "Medicaments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicaments_Patients_PatientId",
                table: "Medicaments");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicaments_Patients_PatientId",
                table: "Medicaments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
