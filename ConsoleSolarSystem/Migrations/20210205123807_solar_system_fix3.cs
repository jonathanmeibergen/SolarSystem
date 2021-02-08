using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleSolarSystem.Migrations
{
    public partial class solar_system_fix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                column: "PlanetType",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                column: "PlanetType",
                value: 0);
        }
    }
}
