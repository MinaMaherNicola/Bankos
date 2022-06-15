using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bankos.DB.Migrations
{
    public partial class AddedNormalizedRoleNameAndRemovedRoleIdFromUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NormalizedRoleName",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NormalizedRoleName",
                table: "UserRoles");
        }
    }
}
