using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleSolarSystem.Migrations
{
    public partial class solar_system_fix5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                column: "Diameter",
                value: "2,306");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                column: "Diameter",
                value: "2,360");
        }
    }
}
