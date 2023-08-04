using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaptopCenter.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CpuModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScreenSize = table.Column<double>(type: "float", nullable: false),
                    CpuDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GpuModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GpuDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HDModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptops");
        }
    }
}
