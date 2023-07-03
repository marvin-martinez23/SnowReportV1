using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnowReport.Migrations
{
    /// <inheritdoc />
    public partial class AnotherMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserFeedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MointainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SnowTotalsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFeedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFeedbacks_SnowTotals_SnowTotalsID",
                        column: x => x.SnowTotalsID,
                        principalTable: "SnowTotals",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFeedbacks_SnowTotalsID",
                table: "UserFeedbacks",
                column: "SnowTotalsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFeedbacks");
        }
    }
}
