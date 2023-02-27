using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMSAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAppUserTypeAndPersonFKToAppUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserTypeId",
                table: "AppUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AppUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFirstLogIn",
                table: "AppUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "AppUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_AppUserTypeId",
                table: "AppUser",
                column: "AppUserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_PersonId",
                table: "AppUser",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_AppUserType_AppUserTypeId",
                table: "AppUser",
                column: "AppUserTypeId",
                principalTable: "AppUserType",
                principalColumn: "AppUserTypeId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_Person_PersonId",
                table: "AppUser",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_AppUserType_AppUserTypeId",
                table: "AppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_Person_PersonId",
                table: "AppUser");

            migrationBuilder.DropIndex(
                name: "IX_AppUser_AppUserTypeId",
                table: "AppUser");

            migrationBuilder.DropIndex(
                name: "IX_AppUser_PersonId",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "AppUserTypeId",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "IsFirstLogIn",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "AppUser");
        }
    }
}
