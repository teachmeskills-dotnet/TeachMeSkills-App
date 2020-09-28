using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachMeSkills.Application.Migrations
{
    public partial class AddLessonSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "lesson");

            migrationBuilder.CreateTable(
                name: "Exercises",
                schema: "lesson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(maxLength: 255, nullable: false),
                    Link = table.Column<string>(maxLength: 127, nullable: true),
                    Comment = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                schema: "lesson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(maxLength: 127, nullable: false),
                    Room = table.Column<string>(maxLength: 63, nullable: false),
                    Floor = table.Column<string>(maxLength: 63, nullable: false),
                    Phone = table.Column<string>(maxLength: 63, nullable: true),
                    Comment = table.Column<string>(maxLength: 127, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                schema: "lesson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    Mark = table.Column<int>(nullable: false),
                    IsVisted = table.Column<bool>(nullable: false),
                    Comment = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statistics_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                schema: "lesson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseMaterialId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    OfficeId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Start = table.Column<DateTime>(type: "date", nullable: false),
                    End = table.Column<DateTime>(type: "date", nullable: false),
                    IsCanceled = table.Column<bool>(nullable: false),
                    IsOffline = table.Column<bool>(nullable: false),
                    Record = table.Column<string>(maxLength: 127, nullable: true),
                    Comment = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_CourseMaterials_CourseMaterialId",
                        column: x => x.CourseMaterialId,
                        principalSchema: "course",
                        principalTable: "CourseMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_Groups_GroupId",
                        column: x => x.GroupId,
                        principalSchema: "group",
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalSchema: "lesson",
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Homeworks",
                schema: "lesson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonId = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ExerciseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homeworks_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalSchema: "lesson",
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homeworks_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "lesson",
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homeworks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LessonStatistics",
                schema: "lesson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonId = table.Column<int>(nullable: false),
                    StatisticId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonStatistics_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "lesson",
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonStatistics_Statistics_StatisticId",
                        column: x => x.StatisticId,
                        principalSchema: "lesson",
                        principalTable: "Statistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_ExerciseId",
                schema: "lesson",
                table: "Homeworks",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_LessonId",
                schema: "lesson",
                table: "Homeworks",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_UserId",
                schema: "lesson",
                table: "Homeworks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseMaterialId",
                schema: "lesson",
                table: "Lessons",
                column: "CourseMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GroupId",
                schema: "lesson",
                table: "Lessons",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_OfficeId",
                schema: "lesson",
                table: "Lessons",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonStatistics_LessonId",
                schema: "lesson",
                table: "LessonStatistics",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonStatistics_StatisticId",
                schema: "lesson",
                table: "LessonStatistics",
                column: "StatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_UserId",
                schema: "lesson",
                table: "Statistics",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Homeworks",
                schema: "lesson");

            migrationBuilder.DropTable(
                name: "LessonStatistics",
                schema: "lesson");

            migrationBuilder.DropTable(
                name: "Exercises",
                schema: "lesson");

            migrationBuilder.DropTable(
                name: "Lessons",
                schema: "lesson");

            migrationBuilder.DropTable(
                name: "Statistics",
                schema: "lesson");

            migrationBuilder.DropTable(
                name: "Offices",
                schema: "lesson");
        }
    }
}
