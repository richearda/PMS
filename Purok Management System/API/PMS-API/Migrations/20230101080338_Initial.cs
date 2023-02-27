using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMSAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodTypes",
                columns: table => new
                {
                    BloodTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypes", x => x.BloodTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Citizenships",
                columns: table => new
                {
                    CitizenshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitizenshipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizenships", x => x.CitizenshipId);
                });

            migrationBuilder.CreateTable(
                name: "CityMunicipalities",
                columns: table => new
                {
                    CityMunicipalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityMunicipalityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BarangayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMunicipalities", x => x.CityMunicipalityId);
                });

            migrationBuilder.CreateTable(
                name: "CivilStatuses",
                columns: table => new
                {
                    CivilStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CivilStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CivilStatuses", x => x.CivilStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Barangays",
                columns: table => new
                {
                    BarangayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarangayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CityMunicipalityId = table.Column<int>(type: "int", nullable: false),
                    PurokSitioId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barangays", x => x.BarangayId);
                    table.ForeignKey(
                        name: "FK_Barangays_CityMunicipalities_CityMunicipalityId",
                        column: x => x.CityMunicipalityId,
                        principalTable: "CityMunicipalities",
                        principalColumn: "CityMunicipalityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurokSitios",
                columns: table => new
                {
                    PurokSitioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurokSitioName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BarangayId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurokSitios", x => x.PurokSitioId);
                    table.ForeignKey(
                        name: "FK_PurokSitios_Barangays_BarangayId",
                        column: x => x.BarangayId,
                        principalTable: "Barangays",
                        principalColumn: "BarangayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseBlockLotNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarangayId = table.Column<int>(type: "int", nullable: false),
                    PurokSitioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Barangays_BarangayId",
                        column: x => x.BarangayId,
                        principalTable: "Barangays",
                        principalColumn: "BarangayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_PurokSitios_PurokSitioId",
                        column: x => x.PurokSitioId,
                        principalTable: "PurokSitios",
                        principalColumn: "PurokSitioId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TelephoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WithNatId = table.Column<bool>(type: "bit", nullable: false),
                    WithSssGsis = table.Column<bool>(type: "bit", nullable: false),
                    WithDriversLicense = table.Column<bool>(type: "bit", nullable: false),
                    IsRegisteredVoter = table.Column<bool>(type: "bit", nullable: false),
                    PrecintNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    BloodTypeId = table.Column<int>(type: "int", nullable: false),
                    CivilStatusId = table.Column<int>(type: "int", nullable: false),
                    CitizenshipId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_People_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_BloodTypes_BloodTypeId",
                        column: x => x.BloodTypeId,
                        principalTable: "BloodTypes",
                        principalColumn: "BloodTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_Citizenships_CitizenshipId",
                        column: x => x.CitizenshipId,
                        principalTable: "Citizenships",
                        principalColumn: "CitizenshipId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_CivilStatuses_CivilStatusId",
                        column: x => x.CivilStatusId,
                        principalTable: "CivilStatuses",
                        principalColumn: "CivilStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_BarangayId",
                table: "Addresses",
                column: "BarangayId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PurokSitioId",
                table: "Addresses",
                column: "PurokSitioId");

            migrationBuilder.CreateIndex(
                name: "IX_Barangays_CityMunicipalityId",
                table: "Barangays",
                column: "CityMunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_People_AddressId",
                table: "People",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_People_BloodTypeId",
                table: "People",
                column: "BloodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_People_CitizenshipId",
                table: "People",
                column: "CitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_People_CivilStatusId",
                table: "People",
                column: "CivilStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_People_GenderId",
                table: "People",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurokSitios_BarangayId",
                table: "PurokSitios",
                column: "BarangayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "BloodTypes");

            migrationBuilder.DropTable(
                name: "Citizenships");

            migrationBuilder.DropTable(
                name: "CivilStatuses");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "PurokSitios");

            migrationBuilder.DropTable(
                name: "Barangays");

            migrationBuilder.DropTable(
                name: "CityMunicipalities");
        }
    }
}
