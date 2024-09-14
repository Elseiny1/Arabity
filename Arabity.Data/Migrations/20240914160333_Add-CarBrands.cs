using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arabity.Data.Migrations
{
    public partial class AddCarBrands : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarBrand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StoreMId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StoreProductParcode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WorkshopId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brand_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Brand_StoreProduct_StoreProductParcode",
                        column: x => x.StoreProductParcode,
                        principalTable: "StoreProduct",
                        principalColumn: "Parcode");
                    table.ForeignKey(
                        name: "FK_Brand_Stores_StoreMId",
                        column: x => x.StoreMId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Brand_Workshops_WorkshopId",
                        column: x => x.WorkshopId,
                        principalTable: "Workshops",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brand_CustomerId",
                table: "Brand",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_StoreMId",
                table: "Brand",
                column: "StoreMId");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_StoreProductParcode",
                table: "Brand",
                column: "StoreProductParcode");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_WorkshopId",
                table: "Brand",
                column: "WorkshopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
