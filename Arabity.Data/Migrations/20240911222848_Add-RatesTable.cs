using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arabity.Data.Migrations
{
    public partial class AddRatesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Workshops");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "StoreProduct");

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    Customer_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ratevalue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    StoreId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WorkshopId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StoreProductParcode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.Customer_Id);
                    table.ForeignKey(
                        name: "FK_Rate_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rate_StoreProduct_StoreProductParcode",
                        column: x => x.StoreProductParcode,
                        principalTable: "StoreProduct",
                        principalColumn: "Parcode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rate_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rate_Workshops_WorkshopId",
                        column: x => x.WorkshopId,
                        principalTable: "Workshops",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rate_StoreId",
                table: "Rate",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Rate_StoreProductParcode",
                table: "Rate",
                column: "StoreProductParcode");

            migrationBuilder.CreateIndex(
                name: "IX_Rate_WorkshopId",
                table: "Rate",
                column: "WorkshopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Workshops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "StoreProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
