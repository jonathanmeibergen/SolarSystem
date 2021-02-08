using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleSolarSystem.Migrations
{
    public partial class solar_system_fix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                column: "NumberOfMoons",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                column: "NumberOfMoons",
                value: 0);
        }
    }
}
