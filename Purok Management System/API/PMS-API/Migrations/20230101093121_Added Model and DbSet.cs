using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMSAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedModelandDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HealthBackgroundId",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HealthBackgrounds",
                columns: table => new
                {
                    HealthBackgroundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMalnurish = table.Column<bool>(type: "bit", nullable: false),
                    IsPwd = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PreExistingConditionId = table.Column<int>(type: "int", nullable: false),
                    VaccinTakenId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthBackgrounds", x => x.HealthBackgroundId);
                    table.ForeignKey(
                        name: "FK_HealthBackgrounds_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequesTypes",
                columns: table => new
                {
                    RequestTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequesTypes", x => x.RequestTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PreExistingConditions",
                columns: table => new
                {
                    PreExistingConditionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    HealthBackgroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreExistingConditions", x => x.PreExistingConditionId);
                    table.ForeignKey(
                        name: "FK_PreExistingConditions_HealthBackgrounds_HealthBackgroundId",
                        column: x => x.HealthBackgroundId,
                        principalTable: "HealthBackgrounds",
                        principalColumn: "HealthBackgroundId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccinesTaken",
                columns: table => new
                {
                    VaccineTakenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    HealthBackgroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinesTaken", x => x.VaccineTakenId);
                    table.ForeignKey(
                        name: "FK_VaccinesTaken_HealthBackgrounds_HealthBackgroundId",
                        column: x => x.HealthBackgroundId,
                        principalTable: "HealthBackgrounds",
                        principalColumn: "HealthBackgroundId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Requests_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_RequesTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalTable: "RequesTypes",
                        principalColumn: "RequestTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthBackgrounds_PersonId",
                table: "HealthBackgrounds",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PreExistingConditions_HealthBackgroundId",
                table: "PreExistingConditions",
                column: "HealthBackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_PersonId",
                table: "Requests",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestTypeId",
                table: "Requests",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccinesTaken_HealthBackgroundId",
                table: "VaccinesTaken",
                column: "HealthBackgroundId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreExistingConditions");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "VaccinesTaken");

            migrationBuilder.DropTable(
                name: "RequesTypes");

            migrationBuilder.DropTable(
                name: "HealthBackgrounds");

            migrationBuilder.DropColumn(
                name: "HealthBackgroundId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "People");
        }
    }
}
