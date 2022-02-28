using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.DAL.Migrations
{
    public partial class Initial_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Bid_BuyOrderOrderId",
                table: "Bid",
                column: "BuyOrderOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyOrder_SupplyTermsContractId",
                table: "BuyOrder",
                column: "SupplyTermsContractId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bid");

            migrationBuilder.DropTable(
                name: "BuyOrder");

            migrationBuilder.DropTable(
                name: "SupplyTermsContract");
        }
    }
}
