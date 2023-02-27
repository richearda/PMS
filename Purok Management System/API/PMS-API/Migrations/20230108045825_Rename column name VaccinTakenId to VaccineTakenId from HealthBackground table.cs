using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMSAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenamecolumnnameVaccinTakenIdtoVaccineTakenIdfromHealthBackgroundtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VaccinTakenId",
                table: "HealthBackgrounds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VaccinTakenId",
                table: "HealthBackgrounds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
