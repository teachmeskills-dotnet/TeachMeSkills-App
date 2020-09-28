using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachMeSkills.Application.Migrations
{
    public partial class AddGroupSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "group");

            migrationBuilder.CreateTable(
                name: "Groups",
                schema: "group",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false),
                    Serial = table.Column<string>(maxLength: 255, nullable: false),
                    Comment = table.Column<string>(maxLength: 127, nullable: true),
                    Start = table.Column<DateTime>(type: "date", nullable: false),
                    End = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Courses_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "course",
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupDetails",
                schema: "group",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AcademicLeaveType = table.Column<int>(nullable: false),
                    Contract = table.Column<string>(maxLength: 127, nullable: false),
                    Start = table.Column<DateTime>(type: "date", nullable: false),
                    End = table.Column<DateTime>(type: "date", nullable: true),
                    Certificate = table.Column<string>(maxLength: 127, nullable: true),
                    Comment = table.Column<string>(maxLength: 127, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupDetails_Groups_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "group",
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupDetails_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetails_GroupId",
                schema: "group",
                table: "GroupDetails",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetails_UserId",
                schema: "group",
                table: "GroupDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CourseId",
                schema: "group",
                table: "Groups",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupDetails",
                schema: "group");

            migrationBuilder.DropTable(
                name: "Groups",
                schema: "group");
        }
    }
}
