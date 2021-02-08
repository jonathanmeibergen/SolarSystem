using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleSolarSystem.Migrations
{
    public partial class solar_system_fix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                column: "SurfaceTemperatureMin",
                value: "472");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1,
                column: "SurfaceTemperatureMin",
                value: "-472");
        }
    }
}
