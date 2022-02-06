using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleDatabase.Migrations
{
    public partial class More_Tabels_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FuelId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuel",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "BrandName" },
                values: new object[,]
                {
                    { 1L, "Volvo" },
                    { 2L, "BMW" },
                    { 3L, "Opel" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "EquipmentName" },
                values: new object[,]
                {
                    { 1L, "Sunroof" },
                    { 2L, "Power Tailgate" },
                    { 3L, "4WD" }
                });

            migrationBuilder.InsertData(
                table: "Fuel",
                columns: new[] { "Id", "FuelName" },
                values: new object[,]
                {
                    { 1L, "95" },
                    { 2L, "98" },
                    { 3L, "Diesel" }
                });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BrandId", "EquipmentId", "FuelId", "ModelName" },
                values: new object[] { 1, 1, 3, "XC90" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Fuel");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FuelId",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ModelName",
                value: "Volvo XC90");
        }
    }
}
