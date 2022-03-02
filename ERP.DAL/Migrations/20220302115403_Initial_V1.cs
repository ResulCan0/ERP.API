using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.DAL.Migrations
{
    public partial class Initial_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductQualityDetails",
                columns: table => new
                {
                    QualityDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aesthetic = table.Column<int>(type: "int", nullable: false),
                    Usability = table.Column<int>(type: "int", nullable: false),
                    Innovation = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductQualityDetails", x => x.QualityDetailId);
                });

            migrationBuilder.CreateTable(
                name: "SupplyTermsContract",
                columns: table => new
                {
                    SupplyTermsContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSigned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyTermsContract", x => x.SupplyTermsContractId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDemand",
                columns: table => new
                {
                    DemandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDemand", x => x.DemandId);
                    table.ForeignKey(
                        name: "FK_ProductDemand_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuyOrder",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyTermsContractId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyOrder", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_BuyOrder_SupplyTermsContract_SupplyTermsContractId",
                        column: x => x.SupplyTermsContractId,
                        principalTable: "SupplyTermsContract",
                        principalColumn: "SupplyTermsContractId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    DealerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DealerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.DealerId);
                    table.ForeignKey(
                        name: "FK_Dealer_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsServiceContractSigned = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Supplier_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bid",
                columns: table => new
                {
                    BidId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BuyOrderOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid", x => x.BidId);
                    table.ForeignKey(
                        name: "FK_Bid_BuyOrder_BuyOrderOrderId",
                        column: x => x.BuyOrderOrderId,
                        principalTable: "BuyOrder",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductQualityDetailsQualityDetailId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DealerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stock_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealer",
                        principalColumn: "DealerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stock_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stock_ProductQualityDetails_ProductQualityDetailsQualityDetailId",
                        column: x => x.ProductQualityDetailsQualityDetailId,
                        principalTable: "ProductQualityDetails",
                        principalColumn: "QualityDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceContract",
                columns: table => new
                {
                    ServiceContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    IsSıgned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceContract", x => x.ServiceContractId);
                    table.ForeignKey(
                        name: "FK_ServiceContract_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bid_BuyOrderOrderId",
                table: "Bid",
                column: "BuyOrderOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyOrder_SupplyTermsContractId",
                table: "BuyOrder",
                column: "SupplyTermsContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_UserId",
                table: "Dealer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDemand_ProductId",
                table: "ProductDemand",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceContract_SupplierId",
                table: "ServiceContract",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_DealerId",
                table: "Stock",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ProductId",
                table: "Stock",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ProductQualityDetailsQualityDetailId",
                table: "Stock",
                column: "ProductQualityDetailsQualityDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_UserId",
                table: "Supplier",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bid");

            migrationBuilder.DropTable(
                name: "ProductDemand");

            migrationBuilder.DropTable(
                name: "ServiceContract");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "BuyOrder");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Dealer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductQualityDetails");

            migrationBuilder.DropTable(
                name: "SupplyTermsContract");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
