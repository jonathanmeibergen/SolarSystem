using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleSolarSystem.Migrations
{
    public partial class more_planets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Diameter", "Name", "NumberOfMoons", "OrbitDistance", "OrbitPeriod", "PlanetType", "StarId", "SurfaceTemperatureMax", "SurfaceTemperatureMin" },
                values: new object[,]
                {
                    { 2, "12,104", "Venus", 0, "108,200,000", "224,7", 0, 1, "", "462" },
                    { 3, "12,756", "Earth", 1, "149,600,000", "365,2", 0, 1, "58", "-88" },
                    { 4, "12,104", "Mars", 2, "227,900,000", "693,88", 0, 1, "", "-63" },
                    { 5, "950", "Ceres", 0, "413,700,000", "1.679,92", 1, 1, "", "-105" },
                    { 6, "142,984", "Jupiter", 67, "778,300,000", "4.345,88", 0, 1, "", "-108" },
                    { 7, "120,536", "Saturn", 62, "1,400,000,000", "20.469,46", 0, 1, "", "-139" },
                    { 8, "51,118", "Uranus", 27, "2,900,000,000", "30.676,8", 0, 1, "", "-197" },
                    { 9, "51,118", "Neptune", 14, "2,900,000,000", "30.676,8", 0, 1, "", "-197" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
