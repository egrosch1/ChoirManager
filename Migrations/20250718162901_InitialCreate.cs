using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChoirManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Masses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rehearsals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rehearsals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Grade = table.Column<int>(type: "integer", nullable: false),
                    ParentFirstName = table.Column<string>(type: "text", nullable: false),
                    ParentLastName = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    WantsSolos = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    MassId = table.Column<int>(type: "integer", nullable: true),
                    RehearsalId = table.Column<int>(type: "integer", nullable: true),
                    WasPresent = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_Masses_MassId",
                        column: x => x.MassId,
                        principalTable: "Masses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_Rehearsals_RehearsalId",
                        column: x => x.RehearsalId,
                        principalTable: "Rehearsals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoloAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    MassId = table.Column<int>(type: "integer", nullable: false),
                    SoloTitle = table.Column<string>(type: "text", nullable: false),
                    WasPerformed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoloAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoloAssignments_Masses_MassId",
                        column: x => x.MassId,
                        principalTable: "Masses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoloAssignments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_MassId",
                table: "AttendanceRecords",
                column: "MassId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_RehearsalId",
                table: "AttendanceRecords",
                column: "RehearsalId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_StudentId",
                table: "AttendanceRecords",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SoloAssignments_MassId",
                table: "SoloAssignments",
                column: "MassId");

            migrationBuilder.CreateIndex(
                name: "IX_SoloAssignments_StudentId",
                table: "SoloAssignments",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceRecords");

            migrationBuilder.DropTable(
                name: "SoloAssignments");

            migrationBuilder.DropTable(
                name: "Rehearsals");

            migrationBuilder.DropTable(
                name: "Masses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
