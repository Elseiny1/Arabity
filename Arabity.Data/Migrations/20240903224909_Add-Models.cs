using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arabity.Data.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Car_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FristName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumbre = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumbre = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workshops",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumbre = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarTypeStoreM",
                columns: table => new
                {
                    CarTypesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StoresId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypeStoreM", x => new { x.CarTypesId, x.StoresId });
                    table.ForeignKey(
                        name: "FK_CarTypeStoreM_CarType_CarTypesId",
                        column: x => x.CarTypesId,
                        principalTable: "CarType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarTypeStoreM_Stores_StoresId",
                        column: x => x.StoresId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreProduct",
                columns: table => new
                {
                    Parcode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Discreption = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    NumberOfPeices = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DateOfPublish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceAfterDiscount = table.Column<double>(type: "float", nullable: false),
                    MadeIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Store_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProduct", x => x.Parcode);
                    table.ForeignKey(
                        name: "FK_StoreProduct_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarTypeWorkshop",
                columns: table => new
                {
                    CarTypesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkshopsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypeWorkshop", x => new { x.CarTypesId, x.WorkshopsId });
                    table.ForeignKey(
                        name: "FK_CarTypeWorkshop_CarType_CarTypesId",
                        column: x => x.CarTypesId,
                        principalTable: "CarType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarTypeWorkshop_Workshops_WorkshopsId",
                        column: x => x.WorkshopsId,
                        principalTable: "Workshops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Open = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Close = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Workshop_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkshopId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Store_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkTime_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkTime_Workshops_WorkshopId",
                        column: x => x.WorkshopId,
                        principalTable: "Workshops",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favourite",
                columns: table => new
                {
                    Customer_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Product_Parcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreProductParcode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourite", x => x.Customer_Id);
                    table.ForeignKey(
                        name: "FK_Favourite_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favourite_StoreProduct_StoreProductParcode",
                        column: x => x.StoreProductParcode,
                        principalTable: "StoreProduct",
                        principalColumn: "Parcode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RattingValue = table.Column<float>(type: "real", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Product_Parcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreProductParcode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Customer_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Store_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Workshop_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkshopId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rate_Customers_CustomerId",
                        column: x => x.CustomerId,
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarTypeStoreM_StoresId",
                table: "CarTypeStoreM",
                column: "StoresId");

            migrationBuilder.CreateIndex(
                name: "IX_CarTypeWorkshop_WorkshopsId",
                table: "CarTypeWorkshop",
                column: "WorkshopsId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_CustomerId",
                table: "Favourite",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_StoreProductParcode",
                table: "Favourite",
                column: "StoreProductParcode");

            migrationBuilder.CreateIndex(
                name: "IX_Rate_CustomerId",
                table: "Rate",
                column: "CustomerId");

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

            migrationBuilder.CreateIndex(
                name: "IX_StoreProduct_StoreId",
                table: "StoreProduct",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTime_StoreId",
                table: "WorkTime",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTime_WorkshopId",
                table: "WorkTime",
                column: "WorkshopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarTypeStoreM");

            migrationBuilder.DropTable(
                name: "CarTypeWorkshop");

            migrationBuilder.DropTable(
                name: "Favourite");

            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropTable(
                name: "WorkTime");

            migrationBuilder.DropTable(
                name: "CarType");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "StoreProduct");

            migrationBuilder.DropTable(
                name: "Workshops");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
