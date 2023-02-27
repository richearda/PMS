using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMSAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemoveBarangayIdReferenceinCityMunicipality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarangayId",
                table: "CityMunicipalities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BarangayId",
                table: "CityMunicipalities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
