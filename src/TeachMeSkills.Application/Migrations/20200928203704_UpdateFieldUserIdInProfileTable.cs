using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachMeSkills.Application.Migrations
{
    public partial class UpdateFieldUserIdInProfileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Profiles_UserId",
                schema: "account",
                table: "Profiles");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "account",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                schema: "account",
                table: "Profiles",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Profiles_UserId",
                schema: "account",
                table: "Profiles");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "account",
                table: "Profiles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                schema: "account",
                table: "Profiles",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }
    }
}
