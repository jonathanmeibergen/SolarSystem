using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleSolarSystem.Migrations
{
    public partial class solar_system : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Diameter", "OrbitDistance", "OrbitPeriod", "SurfaceTemperatureMin" },
                values: new object[] { "49,528", "4,500,000,000", "60.184,96", "-201" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Diameter", "Name", "NumberOfMoons", "OrbitDistance", "OrbitPeriod", "PlanetType", "StarId", "SurfaceTemperatureMax", "SurfaceTemperatureMin" },
                values: new object[,]
                {
                    { 10, "2,360", "Pluto", 5, "5,900,000,000", "89.839,2", 0, 1, "", "-229" },
                    { 11, "1,518", "Haumea", 2, "6,400,000,000", "103.461,16", 1, 1, "", "-241" },
                    { 12, "1,434", "Makemake", 0, "6,900,000,000", "113.175,48", 1, 1, "", "-239" },
                    { 13, "2,326", "Eris", 0, "10,100,000,000", "204.840,68", 1, 1, "", "-231" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Diameter", "OrbitDistance", "OrbitPeriod", "SurfaceTemperatureMin" },
                values: new object[] { "51,118", "2,900,000,000", "30.676,8", "-197" });
        }
    }
}
