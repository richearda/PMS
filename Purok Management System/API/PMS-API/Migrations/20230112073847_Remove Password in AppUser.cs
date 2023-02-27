using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMSAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemovePasswordinAppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AppUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
