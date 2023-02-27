using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMSAPI.Migrations
{
    /// <inheritdoc />
    public partial class ModifyRelationshipproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthBackgrounds_People_PersonId",
                table: "HealthBackgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_PreExistingConditions_HealthBackgrounds_HealthBackgroundId",
                table: "PreExistingConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinesTaken_HealthBackgrounds_HealthBackgroundId",
                table: "VaccinesTaken");

            migrationBuilder.DropIndex(
                name: "IX_VaccinesTaken_HealthBackgroundId",
                table: "VaccinesTaken");

            migrationBuilder.DropIndex(
                name: "IX_PreExistingConditions_HealthBackgroundId",
                table: "PreExistingConditions");

            migrationBuilder.DropColumn(
                name: "HealthBackgroundId",
                table: "VaccinesTaken");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "RequesTypes");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "PurokSitios");

            migrationBuilder.DropColumn(
                name: "HealthBackgroundId",
                table: "PreExistingConditions");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "CivilStatuses");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Citizenships");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "BloodTypes");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Barangays");

            migrationBuilder.DropColumn(
                name: "PurokSitioId",
                table: "Barangays");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "HealthBackgrounds",
                newName: "VaccineTakenId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthBackgrounds_PersonId",
                table: "HealthBackgrounds",
                newName: "IX_HealthBackgrounds_VaccineTakenId");

            migrationBuilder.CreateIndex(
                name: "IX_People_HealthBackgroundId",
                table: "People",
                column: "HealthBackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthBackgrounds_PreExistingConditionId",
                table: "HealthBackgrounds",
                column: "PreExistingConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthBackgrounds_PreExistingConditions_PreExistingConditionId",
                table: "HealthBackgrounds",
                column: "PreExistingConditionId",
                principalTable: "PreExistingConditions",
                principalColumn: "PreExistingConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthBackgrounds_VaccinesTaken_VaccineTakenId",
                table: "HealthBackgrounds",
                column: "VaccineTakenId",
                principalTable: "VaccinesTaken",
                principalColumn: "VaccineTakenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_HealthBackgrounds_HealthBackgroundId",
                table: "People",
                column: "HealthBackgroundId",
                principalTable: "HealthBackgrounds",
                principalColumn: "HealthBackgroundId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthBackgrounds_PreExistingConditions_PreExistingConditionId",
                table: "HealthBackgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthBackgrounds_VaccinesTaken_VaccineTakenId",
                table: "HealthBackgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_People_HealthBackgrounds_HealthBackgroundId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_HealthBackgroundId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_HealthBackgrounds_PreExistingConditionId",
                table: "HealthBackgrounds");

            migrationBuilder.RenameColumn(
                name: "VaccineTakenId",
                table: "HealthBackgrounds",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthBackgrounds_VaccineTakenId",
                table: "HealthBackgrounds",
                newName: "IX_HealthBackgrounds_PersonId");

            migrationBuilder.AddColumn<int>(
                name: "HealthBackgroundId",
                table: "VaccinesTaken",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "RequesTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "PurokSitios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HealthBackgroundId",
                table: "PreExistingConditions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Genders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "CivilStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Citizenships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "BloodTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Barangays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PurokSitioId",
                table: "Barangays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VaccinesTaken_HealthBackgroundId",
                table: "VaccinesTaken",
                column: "HealthBackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_PreExistingConditions_HealthBackgroundId",
                table: "PreExistingConditions",
                column: "HealthBackgroundId");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthBackgrounds_People_PersonId",
                table: "HealthBackgrounds",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreExistingConditions_HealthBackgrounds_HealthBackgroundId",
                table: "PreExistingConditions",
                column: "HealthBackgroundId",
                principalTable: "HealthBackgrounds",
                principalColumn: "HealthBackgroundId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinesTaken_HealthBackgrounds_HealthBackgroundId",
                table: "VaccinesTaken",
                column: "HealthBackgroundId",
                principalTable: "HealthBackgrounds",
                principalColumn: "HealthBackgroundId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
