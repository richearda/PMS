using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMSAPI.Migrations
{
    /// <inheritdoc />
    public partial class Removepluralizednamingoftablesindatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Barangays_BarangayId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_PurokSitios_PurokSitioId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Barangays_CityMunicipalities_CityMunicipalityId",
                table: "Barangays");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthBackgrounds_PreExistingConditions_PreExistingConditionId",
                table: "HealthBackgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthBackgrounds_VaccinesTaken_VaccineTakenId",
                table: "HealthBackgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Addresses_AddressId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_BloodTypes_BloodTypeId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Citizenships_CitizenshipId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_CivilStatuses_CivilStatusId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Genders_GenderId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_HealthBackgrounds_HealthBackgroundId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_PurokSitios_Barangays_BarangayId",
                table: "PurokSitios");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_People_PersonId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_RequesTypes_RequestTypeId",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaccinesTaken",
                table: "VaccinesTaken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequesTypes",
                table: "RequesTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurokSitios",
                table: "PurokSitios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PreExistingConditions",
                table: "PreExistingConditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthBackgrounds",
                table: "HealthBackgrounds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CivilStatuses",
                table: "CivilStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CityMunicipalities",
                table: "CityMunicipalities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Citizenships",
                table: "Citizenships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BloodTypes",
                table: "BloodTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Barangays",
                table: "Barangays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "VaccinesTaken",
                newName: "VaccineTaken");

            migrationBuilder.RenameTable(
                name: "RequesTypes",
                newName: "RequestType");

            migrationBuilder.RenameTable(
                name: "Requests",
                newName: "Request");

            migrationBuilder.RenameTable(
                name: "PurokSitios",
                newName: "PurokSitio");

            migrationBuilder.RenameTable(
                name: "PreExistingConditions",
                newName: "PreExistingCondition");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Person");

            migrationBuilder.RenameTable(
                name: "HealthBackgrounds",
                newName: "HealthBackground");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Gender");

            migrationBuilder.RenameTable(
                name: "CivilStatuses",
                newName: "CivilStatus");

            migrationBuilder.RenameTable(
                name: "CityMunicipalities",
                newName: "CityMunicipality");

            migrationBuilder.RenameTable(
                name: "Citizenships",
                newName: "Citizenship");

            migrationBuilder.RenameTable(
                name: "BloodTypes",
                newName: "BloodType");

            migrationBuilder.RenameTable(
                name: "Barangays",
                newName: "Barangay");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_RequestTypeId",
                table: "Request",
                newName: "IX_Request_RequestTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_PersonId",
                table: "Request",
                newName: "IX_Request_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_PurokSitios_BarangayId",
                table: "PurokSitio",
                newName: "IX_PurokSitio_BarangayId");

            migrationBuilder.RenameIndex(
                name: "IX_People_HealthBackgroundId",
                table: "Person",
                newName: "IX_Person_HealthBackgroundId");

            migrationBuilder.RenameIndex(
                name: "IX_People_GenderId",
                table: "Person",
                newName: "IX_Person_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_People_CivilStatusId",
                table: "Person",
                newName: "IX_Person_CivilStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_People_CitizenshipId",
                table: "Person",
                newName: "IX_Person_CitizenshipId");

            migrationBuilder.RenameIndex(
                name: "IX_People_BloodTypeId",
                table: "Person",
                newName: "IX_Person_BloodTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_People_AddressId",
                table: "Person",
                newName: "IX_Person_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthBackgrounds_VaccineTakenId",
                table: "HealthBackground",
                newName: "IX_HealthBackground_VaccineTakenId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthBackgrounds_PreExistingConditionId",
                table: "HealthBackground",
                newName: "IX_HealthBackground_PreExistingConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_Barangays_CityMunicipalityId",
                table: "Barangay",
                newName: "IX_Barangay_CityMunicipalityId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_PurokSitioId",
                table: "Address",
                newName: "IX_Address_PurokSitioId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_BarangayId",
                table: "Address",
                newName: "IX_Address_BarangayId");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "VaccineTaken",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaccineTaken",
                table: "VaccineTaken",
                column: "VaccineTakenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestType",
                table: "RequestType",
                column: "RequestTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Request",
                table: "Request",
                column: "RequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurokSitio",
                table: "PurokSitio",
                column: "PurokSitioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PreExistingCondition",
                table: "PreExistingCondition",
                column: "PreExistingConditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthBackground",
                table: "HealthBackground",
                column: "HealthBackgroundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "GenderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CivilStatus",
                table: "CivilStatus",
                column: "CivilStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CityMunicipality",
                table: "CityMunicipality",
                column: "CityMunicipalityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Citizenship",
                table: "Citizenship",
                column: "CitizenshipId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BloodType",
                table: "BloodType",
                column: "BloodTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Barangay",
                table: "Barangay",
                column: "BarangayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Barangay_BarangayId",
                table: "Address",
                column: "BarangayId",
                principalTable: "Barangay",
                principalColumn: "BarangayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_PurokSitio_PurokSitioId",
                table: "Address",
                column: "PurokSitioId",
                principalTable: "PurokSitio",
                principalColumn: "PurokSitioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Barangay_CityMunicipality_CityMunicipalityId",
                table: "Barangay",
                column: "CityMunicipalityId",
                principalTable: "CityMunicipality",
                principalColumn: "CityMunicipalityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthBackground_PreExistingCondition_PreExistingConditionId",
                table: "HealthBackground",
                column: "PreExistingConditionId",
                principalTable: "PreExistingCondition",
                principalColumn: "PreExistingConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthBackground_VaccineTaken_VaccineTakenId",
                table: "HealthBackground",
                column: "VaccineTakenId",
                principalTable: "VaccineTaken",
                principalColumn: "VaccineTakenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_BloodType_BloodTypeId",
                table: "Person",
                column: "BloodTypeId",
                principalTable: "BloodType",
                principalColumn: "BloodTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Citizenship_CitizenshipId",
                table: "Person",
                column: "CitizenshipId",
                principalTable: "Citizenship",
                principalColumn: "CitizenshipId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_CivilStatus_CivilStatusId",
                table: "Person",
                column: "CivilStatusId",
                principalTable: "CivilStatus",
                principalColumn: "CivilStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Gender_GenderId",
                table: "Person",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_HealthBackground_HealthBackgroundId",
                table: "Person",
                column: "HealthBackgroundId",
                principalTable: "HealthBackground",
                principalColumn: "HealthBackgroundId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurokSitio_Barangay_BarangayId",
                table: "PurokSitio",
                column: "BarangayId",
                principalTable: "Barangay",
                principalColumn: "BarangayId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Person_PersonId",
                table: "Request",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_RequestType_RequestTypeId",
                table: "Request",
                column: "RequestTypeId",
                principalTable: "RequestType",
                principalColumn: "RequestTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Barangay_BarangayId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_PurokSitio_PurokSitioId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Barangay_CityMunicipality_CityMunicipalityId",
                table: "Barangay");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthBackground_PreExistingCondition_PreExistingConditionId",
                table: "HealthBackground");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthBackground_VaccineTaken_VaccineTakenId",
                table: "HealthBackground");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_BloodType_BloodTypeId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Citizenship_CitizenshipId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_CivilStatus_CivilStatusId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Gender_GenderId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_HealthBackground_HealthBackgroundId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PurokSitio_Barangay_BarangayId",
                table: "PurokSitio");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Person_PersonId",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_RequestType_RequestTypeId",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaccineTaken",
                table: "VaccineTaken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestType",
                table: "RequestType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Request",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurokSitio",
                table: "PurokSitio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PreExistingCondition",
                table: "PreExistingCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthBackground",
                table: "HealthBackground");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CivilStatus",
                table: "CivilStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CityMunicipality",
                table: "CityMunicipality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Citizenship",
                table: "Citizenship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BloodType",
                table: "BloodType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Barangay",
                table: "Barangay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "VaccineTaken");

            migrationBuilder.RenameTable(
                name: "VaccineTaken",
                newName: "VaccinesTaken");

            migrationBuilder.RenameTable(
                name: "RequestType",
                newName: "RequesTypes");

            migrationBuilder.RenameTable(
                name: "Request",
                newName: "Requests");

            migrationBuilder.RenameTable(
                name: "PurokSitio",
                newName: "PurokSitios");

            migrationBuilder.RenameTable(
                name: "PreExistingCondition",
                newName: "PreExistingConditions");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "People");

            migrationBuilder.RenameTable(
                name: "HealthBackground",
                newName: "HealthBackgrounds");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "CivilStatus",
                newName: "CivilStatuses");

            migrationBuilder.RenameTable(
                name: "CityMunicipality",
                newName: "CityMunicipalities");

            migrationBuilder.RenameTable(
                name: "Citizenship",
                newName: "Citizenships");

            migrationBuilder.RenameTable(
                name: "BloodType",
                newName: "BloodTypes");

            migrationBuilder.RenameTable(
                name: "Barangay",
                newName: "Barangays");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Request_RequestTypeId",
                table: "Requests",
                newName: "IX_Requests_RequestTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Request_PersonId",
                table: "Requests",
                newName: "IX_Requests_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_PurokSitio_BarangayId",
                table: "PurokSitios",
                newName: "IX_PurokSitios_BarangayId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_HealthBackgroundId",
                table: "People",
                newName: "IX_People_HealthBackgroundId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_GenderId",
                table: "People",
                newName: "IX_People_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_CivilStatusId",
                table: "People",
                newName: "IX_People_CivilStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_CitizenshipId",
                table: "People",
                newName: "IX_People_CitizenshipId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_BloodTypeId",
                table: "People",
                newName: "IX_People_BloodTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Person_AddressId",
                table: "People",
                newName: "IX_People_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthBackground_VaccineTakenId",
                table: "HealthBackgrounds",
                newName: "IX_HealthBackgrounds_VaccineTakenId");

            migrationBuilder.RenameIndex(
                name: "IX_HealthBackground_PreExistingConditionId",
                table: "HealthBackgrounds",
                newName: "IX_HealthBackgrounds_PreExistingConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_Barangay_CityMunicipalityId",
                table: "Barangays",
                newName: "IX_Barangays_CityMunicipalityId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_PurokSitioId",
                table: "Addresses",
                newName: "IX_Addresses_PurokSitioId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_BarangayId",
                table: "Addresses",
                newName: "IX_Addresses_BarangayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaccinesTaken",
                table: "VaccinesTaken",
                column: "VaccineTakenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequesTypes",
                table: "RequesTypes",
                column: "RequestTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "RequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurokSitios",
                table: "PurokSitios",
                column: "PurokSitioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PreExistingConditions",
                table: "PreExistingConditions",
                column: "PreExistingConditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthBackgrounds",
                table: "HealthBackgrounds",
                column: "HealthBackgroundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "GenderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CivilStatuses",
                table: "CivilStatuses",
                column: "CivilStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CityMunicipalities",
                table: "CityMunicipalities",
                column: "CityMunicipalityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Citizenships",
                table: "Citizenships",
                column: "CitizenshipId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BloodTypes",
                table: "BloodTypes",
                column: "BloodTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Barangays",
                table: "Barangays",
                column: "BarangayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Barangays_BarangayId",
                table: "Addresses",
                column: "BarangayId",
                principalTable: "Barangays",
                principalColumn: "BarangayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_PurokSitios_PurokSitioId",
                table: "Addresses",
                column: "PurokSitioId",
                principalTable: "PurokSitios",
                principalColumn: "PurokSitioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Barangays_CityMunicipalities_CityMunicipalityId",
                table: "Barangays",
                column: "CityMunicipalityId",
                principalTable: "CityMunicipalities",
                principalColumn: "CityMunicipalityId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_People_Addresses_AddressId",
                table: "People",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_BloodTypes_BloodTypeId",
                table: "People",
                column: "BloodTypeId",
                principalTable: "BloodTypes",
                principalColumn: "BloodTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Citizenships_CitizenshipId",
                table: "People",
                column: "CitizenshipId",
                principalTable: "Citizenships",
                principalColumn: "CitizenshipId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_CivilStatuses_CivilStatusId",
                table: "People",
                column: "CivilStatusId",
                principalTable: "CivilStatuses",
                principalColumn: "CivilStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Genders_GenderId",
                table: "People",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_HealthBackgrounds_HealthBackgroundId",
                table: "People",
                column: "HealthBackgroundId",
                principalTable: "HealthBackgrounds",
                principalColumn: "HealthBackgroundId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurokSitios_Barangays_BarangayId",
                table: "PurokSitios",
                column: "BarangayId",
                principalTable: "Barangays",
                principalColumn: "BarangayId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_People_PersonId",
                table: "Requests",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_RequesTypes_RequestTypeId",
                table: "Requests",
                column: "RequestTypeId",
                principalTable: "RequesTypes",
                principalColumn: "RequestTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
