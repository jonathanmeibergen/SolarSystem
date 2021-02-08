using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleSolarSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diameter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfaceTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoreTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanetType = table.Column<int>(type: "int", nullable: false),
                    Diameter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrbitDistance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrbitPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfaceTemperatureMin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfaceTemperatureMax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfMoons = table.Column<int>(type: "int", nullable: false),
                    StarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planets_Stars_StarId",
                        column: x => x.StarId,
                        principalTable: "Stars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanetId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moons_Planets_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Stars",
                columns: new[] { "Id", "Age", "CoreTemperature", "Diameter", "Name", "SurfaceTemperature" },
                values: new object[] { 1, "4,600,000,000", "15,000,000", "1,392,684", "The Sun", "5,500" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Diameter", "Name", "NumberOfMoons", "OrbitDistance", "OrbitPeriod", "PlanetType", "StarId", "SurfaceTemperatureMax", "SurfaceTemperatureMin" },
                values: new object[] { 1, "4,879", "Mercury", 0, "57,900,000", "88", 0, 1, "-173", "-472" });

            migrationBuilder.CreateIndex(
                name: "IX_Moons_PlanetId",
                table: "Moons",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_Planets_StarId",
                table: "Planets",
                column: "StarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moons");

            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "Stars");
        }
    }
}
