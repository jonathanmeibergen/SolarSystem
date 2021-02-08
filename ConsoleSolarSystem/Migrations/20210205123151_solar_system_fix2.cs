using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleSolarSystem.Migrations
{
    public partial class solar_system_fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrbitPeriod",
                value: "224.7");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrbitPeriod",
                value: "365.2");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrbitPeriod",
                value: "693.88");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrbitPeriod",
                value: "1,679.92");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrbitPeriod",
                value: "4,345.88");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrbitPeriod",
                value: "20,469.46");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrbitPeriod",
                value: "30,676.8");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrbitPeriod",
                value: "60,184.96");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrbitPeriod",
                value: "89,839.2");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrbitPeriod",
                value: "103,461.16");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12,
                column: "OrbitPeriod",
                value: "113,175.48");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                column: "OrbitPeriod",
                value: "204,840.68");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrbitPeriod",
                value: "224,7");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrbitPeriod",
                value: "365,2");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrbitPeriod",
                value: "693,88");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrbitPeriod",
                value: "1.679,92");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrbitPeriod",
                value: "4.345,88");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrbitPeriod",
                value: "20.469,46");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrbitPeriod",
                value: "30.676,8");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrbitPeriod",
                value: "60.184,96");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrbitPeriod",
                value: "89.839,2");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrbitPeriod",
                value: "103.461,16");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12,
                column: "OrbitPeriod",
                value: "113.175,48");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13,
                column: "OrbitPeriod",
                value: "204.840,68");
        }
    }
}
