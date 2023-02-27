using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMSAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCityMunicipalityFKConstraintinAddresstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityMunicipalityId",
                table: "Address",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Address_CityMunicipalityId",
                table: "Address",
                column: "CityMunicipalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_CityMunicipality_CityMunicipalityId",
                table: "Address",
                column: "CityMunicipalityId",
                principalTable: "CityMunicipality",
                principalColumn: "CityMunicipalityId",
                onDelete: ReferentialAction.NoAction);
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_CityMunicipality_CityMunicipalityId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_CityMunicipalityId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "CityMunicipalityId",
                table: "Address");
        }
    }
}
