using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VisitorManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomePages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitorMilitaryID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Visitors",
                columns: new[] { "Id", "Job", "Purpose", "Rank", "RequestTime", "Status", "VisitorMilitaryID", "VisitorName" },
                values: new object[,]
                {
                    { 1, "رئيس فرع النظم", "سري", "نقيب", new DateTime(2025, 7, 13, 12, 1, 34, 760, DateTimeKind.Utc).AddTicks(1210), "Pending", "", "اسلام محمود محمد" },
                    { 2, "رئيس فرع التجنيد", "طلبية يوليو", "عقيد", new DateTime(2025, 7, 13, 12, 1, 34, 760, DateTimeKind.Utc).AddTicks(1213), "Pending", "", "محمود القناوي" },
                    { 3, "رئيس فرع المجمع", "سري", "نقيب", new DateTime(2025, 7, 13, 12, 1, 34, 760, DateTimeKind.Utc).AddTicks(1215), "Pending", "", "محمود نزية" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePages");

            migrationBuilder.DropTable(
                name: "Visitors");
        }
    }
}
