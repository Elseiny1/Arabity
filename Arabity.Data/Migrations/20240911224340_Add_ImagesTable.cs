using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arabity.Data.Migrations
{
    public partial class Add_ImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    StoreMId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StoreProductParcode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WorkshopId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_StoreProduct_StoreProductParcode",
                        column: x => x.StoreProductParcode,
                        principalTable: "StoreProduct",
                        principalColumn: "Parcode");
                    table.ForeignKey(
                        name: "FK_Image_Stores_StoreMId",
                        column: x => x.StoreMId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Image_Workshops_WorkshopId",
                        column: x => x.WorkshopId,
                        principalTable: "Workshops",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_StoreMId",
                table: "Image",
                column: "StoreMId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_StoreProductParcode",
                table: "Image",
                column: "StoreProductParcode");

            migrationBuilder.CreateIndex(
                name: "IX_Image_WorkshopId",
                table: "Image",
                column: "WorkshopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}
