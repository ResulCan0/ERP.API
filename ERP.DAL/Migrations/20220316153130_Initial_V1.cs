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
                name: "Costs",
                columns: table => new
                {
                    CostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingCost = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FirmCost = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BankCommission = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.CostId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    DealerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.DealerId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDeliveries",
                columns: table => new
                {
                    ProductDeliveryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDeliveries", x => x.ProductDeliveryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    ProductFeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Appearance = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Availabiliyt = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Functionality = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Innovation = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    PriceAdvantage = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    CriterionNote = table.Column<int>(type: "int", precision: 2, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.ProductFeatureId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "DealerPayments",
                columns: table => new
                {
                    DealerPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentStatus = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    DealerId = table.Column<int>(type: "int", nullable: false),
                    AmountPay = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerPayments", x => x.DealerPaymentId);
                    table.ForeignKey(
                        name: "FK_DealerPayments_Dealers_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealers",
                        principalColumn: "DealerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DealerProductDemands",
                columns: table => new
                {
                    DealerProductDemandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    DealerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerProductDemands", x => x.DealerProductDemandId);
                    table.ForeignKey(
                        name: "FK_DealerProductDemands_Dealers_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealers",
                        principalColumn: "DealerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DealerProductDemands_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DealerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Dealers_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealers",
                        principalColumn: "DealerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierProductSupplyContracts",
                columns: table => new
                {
                    SupplierProductSupplyContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSigned = table.Column<bool>(type: "bit", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SignedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierProductSupplyContracts", x => x.SupplierProductSupplyContractId);
                    table.ForeignKey(
                        name: "FK_SupplierProductSupplyContracts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierProductSupplyContracts_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerPaymentId = table.Column<int>(type: "int", nullable: false),
                    ProductDeliveryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_DealerPayments_DealerPaymentId",
                        column: x => x.DealerPaymentId,
                        principalTable: "DealerPayments",
                        principalColumn: "DealerPaymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_ProductDeliveries_ProductDeliveryId",
                        column: x => x.ProductDeliveryId,
                        principalTable: "ProductDeliveries",
                        principalColumn: "ProductDeliveryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DealerProductFeatureSuggestions",
                columns: table => new
                {
                    DealerProductFeatureSuggestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerProductDemandId = table.Column<int>(type: "int", nullable: false),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerProductFeatureSuggestions", x => x.DealerProductFeatureSuggestionId);
                    table.ForeignKey(
                        name: "FK_DealerProductFeatureSuggestions_DealerProductDemands_DealerProductDemandId",
                        column: x => x.DealerProductDemandId,
                        principalTable: "DealerProductDemands",
                        principalColumn: "DealerProductDemandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DealerProductFeatureSuggestions_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "ProductFeatureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DealerProductSales",
                columns: table => new
                {
                    DealerProductSaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerProductSales", x => x.DealerProductSaleId);
                    table.ForeignKey(
                        name: "FK_DealerProductSales_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchasingDepartments",
                columns: table => new
                {
                    PurchasingDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerProductFeatureSuggestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasingDepartments", x => x.PurchasingDepartmentId);
                    table.ForeignKey(
                        name: "FK_PurchasingDepartments_DealerProductFeatureSuggestions_DealerProductFeatureSuggestionId",
                        column: x => x.DealerProductFeatureSuggestionId,
                        principalTable: "DealerProductFeatureSuggestions",
                        principalColumn: "DealerProductFeatureSuggestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfferForSales",
                columns: table => new
                {
                    OfferForSaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerProductSaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferForSales", x => x.OfferForSaleId);
                    table.ForeignKey(
                        name: "FK_OfferForSales_DealerProductSales_DealerProductSaleId",
                        column: x => x.DealerProductSaleId,
                        principalTable: "DealerProductSales",
                        principalColumn: "DealerProductSaleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierProductFeatures",
                columns: table => new
                {
                    SupplierProductFeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductFeatureId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    PurchasingDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierProductFeatures", x => x.SupplierProductFeatureId);
                    table.ForeignKey(
                        name: "FK_SupplierProductFeatures_ProductFeatures_ProductFeatureId",
                        column: x => x.ProductFeatureId,
                        principalTable: "ProductFeatures",
                        principalColumn: "ProductFeatureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierProductFeatures_PurchasingDepartments_PurchasingDepartmentId",
                        column: x => x.PurchasingDepartmentId,
                        principalTable: "PurchasingDepartments",
                        principalColumn: "PurchasingDepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierProductFeatures_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Buys",
                columns: table => new
                {
                    BuyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    OfferForSaleId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buys", x => x.BuyId);
                    table.ForeignKey(
                        name: "FK_Buys_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Buys_OfferForSales_OfferForSaleId",
                        column: x => x.OfferForSaleId,
                        principalTable: "OfferForSales",
                        principalColumn: "OfferForSaleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierProductPrices",
                columns: table => new
                {
                    SupplierProductPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    SupplierProductFeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierProductPrices", x => x.SupplierProductPriceId);
                    table.ForeignKey(
                        name: "FK_SupplierProductPrices_SupplierProductFeatures_SupplierProductFeatureId",
                        column: x => x.SupplierProductFeatureId,
                        principalTable: "SupplierProductFeatures",
                        principalColumn: "SupplierProductFeatureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPayments",
                columns: table => new
                {
                    CustomerPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    BuyId = table.Column<int>(type: "int", nullable: false),
                    AmountPay = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPayments", x => x.CustomerPaymentId);
                    table.ForeignKey(
                        name: "FK_CustomerPayments_Buys_BuyId",
                        column: x => x.BuyId,
                        principalTable: "Buys",
                        principalColumn: "BuyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TotalAmountPayables",
                columns: table => new
                {
                    TotalAmountPayableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmountPayablePrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CostId = table.Column<int>(type: "int", nullable: false),
                    SupplierProductPriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalAmountPayables", x => x.TotalAmountPayableId);
                    table.ForeignKey(
                        name: "FK_TotalAmountPayables_Costs_CostId",
                        column: x => x.CostId,
                        principalTable: "Costs",
                        principalColumn: "CostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TotalAmountPayables_SupplierProductPrices_SupplierProductPriceId",
                        column: x => x.SupplierProductPriceId,
                        principalTable: "SupplierProductPrices",
                        principalColumn: "SupplierProductPriceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBankAccounts",
                columns: table => new
                {
                    CustomerBankAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerPaymentId = table.Column<int>(type: "int", nullable: false),
                    MoneyInAccount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBankAccounts", x => x.CustomerBankAccountId);
                    table.ForeignKey(
                        name: "FK_CustomerBankAccounts_CustomerPayments_CustomerPaymentId",
                        column: x => x.CustomerPaymentId,
                        principalTable: "CustomerPayments",
                        principalColumn: "CustomerPaymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerBankAccounts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchasingDepartmentPrices",
                columns: table => new
                {
                    PurchasingDepartmentPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accepted = table.Column<bool>(type: "bit", nullable: false),
                    TotalAmountPayableId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasingDepartmentPrices", x => x.PurchasingDepartmentPriceId);
                    table.ForeignKey(
                        name: "FK_PurchasingDepartmentPrices_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "StockId");
                    table.ForeignKey(
                        name: "FK_PurchasingDepartmentPrices_TotalAmountPayables_TotalAmountPayableId",
                        column: x => x.TotalAmountPayableId,
                        principalTable: "TotalAmountPayables",
                        principalColumn: "TotalAmountPayableId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentConfirmations",
                columns: table => new
                {
                    PaymentConfirmationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accepted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerBankAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentConfirmations", x => x.PaymentConfirmationId);
                    table.ForeignKey(
                        name: "FK_PaymentConfirmations_CustomerBankAccounts_CustomerBankAccountId",
                        column: x => x.CustomerBankAccountId,
                        principalTable: "CustomerBankAccounts",
                        principalColumn: "CustomerBankAccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierPurchaseServiceAgreements",
                columns: table => new
                {
                    SupplierPurchaseServiceAgreementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSigned = table.Column<bool>(type: "bit", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    PurchasingDepartmentPriceId = table.Column<int>(type: "int", nullable: false),
                    SignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SignedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPurchaseServiceAgreements", x => x.SupplierPurchaseServiceAgreementId);
                    table.ForeignKey(
                        name: "FK_SupplierPurchaseServiceAgreements_PurchasingDepartmentPrices_PurchasingDepartmentPriceId",
                        column: x => x.PurchasingDepartmentPriceId,
                        principalTable: "PurchasingDepartmentPrices",
                        principalColumn: "PurchasingDepartmentPriceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierPurchaseServiceAgreements_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FinanceDepartments",
                columns: table => new
                {
                    FinanceDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeePayment = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    PurchasingDepartmentPriceId = table.Column<int>(type: "int", nullable: false),
                    PaymentConfirmationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceDepartments", x => x.FinanceDepartmentId);
                    table.ForeignKey(
                        name: "FK_FinanceDepartments_PaymentConfirmations_PaymentConfirmationId",
                        column: x => x.PaymentConfirmationId,
                        principalTable: "PaymentConfirmations",
                        principalColumn: "PaymentConfirmationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FinanceDepartments_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FinanceDepartments_PurchasingDepartmentPrices_PurchasingDepartmentPriceId",
                        column: x => x.PurchasingDepartmentPriceId,
                        principalTable: "PurchasingDepartmentPrices",
                        principalColumn: "PurchasingDepartmentPriceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DealerBankAccounts",
                columns: table => new
                {
                    DealerBankAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    DealerId = table.Column<int>(type: "int", nullable: false),
                    FinanceDepartmentId = table.Column<int>(type: "int", nullable: false),
                    MoneyInAccount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerBankAccounts", x => x.DealerBankAccountId);
                    table.ForeignKey(
                        name: "FK_DealerBankAccounts_Dealers_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealers",
                        principalColumn: "DealerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DealerBankAccounts_FinanceDepartments_FinanceDepartmentId",
                        column: x => x.FinanceDepartmentId,
                        principalTable: "FinanceDepartments",
                        principalColumn: "FinanceDepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buys_CustomerId",
                table: "Buys",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Buys_OfferForSaleId",
                table: "Buys",
                column: "OfferForSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBankAccounts_CustomerId",
                table: "CustomerBankAccounts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBankAccounts_CustomerPaymentId",
                table: "CustomerBankAccounts",
                column: "CustomerPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPayments_BuyId",
                table: "CustomerPayments",
                column: "BuyId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerBankAccounts_DealerId",
                table: "DealerBankAccounts",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerBankAccounts_FinanceDepartmentId",
                table: "DealerBankAccounts",
                column: "FinanceDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerPayments_DealerId",
                table: "DealerPayments",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerProductDemands_DealerId",
                table: "DealerProductDemands",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerProductDemands_ProductId",
                table: "DealerProductDemands",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerProductFeatureSuggestions_DealerProductDemandId",
                table: "DealerProductFeatureSuggestions",
                column: "DealerProductDemandId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerProductFeatureSuggestions_ProductFeaturesId",
                table: "DealerProductFeatureSuggestions",
                column: "ProductFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerProductSales_StockId",
                table: "DealerProductSales",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceDepartments_PaymentConfirmationId",
                table: "FinanceDepartments",
                column: "PaymentConfirmationId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceDepartments_PaymentId",
                table: "FinanceDepartments",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceDepartments_PurchasingDepartmentPriceId",
                table: "FinanceDepartments",
                column: "PurchasingDepartmentPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferForSales_DealerProductSaleId",
                table: "OfferForSales",
                column: "DealerProductSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentConfirmations_CustomerBankAccountId",
                table: "PaymentConfirmations",
                column: "CustomerBankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_DealerPaymentId",
                table: "Payments",
                column: "DealerPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ProductDeliveryId",
                table: "Payments",
                column: "ProductDeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasingDepartmentPrices_StockId",
                table: "PurchasingDepartmentPrices",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasingDepartmentPrices_TotalAmountPayableId",
                table: "PurchasingDepartmentPrices",
                column: "TotalAmountPayableId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasingDepartments_DealerProductFeatureSuggestionId",
                table: "PurchasingDepartments",
                column: "DealerProductFeatureSuggestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_DealerId",
                table: "Stocks",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProductFeatures_ProductFeatureId",
                table: "SupplierProductFeatures",
                column: "ProductFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProductFeatures_PurchasingDepartmentId",
                table: "SupplierProductFeatures",
                column: "PurchasingDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProductFeatures_SupplierId",
                table: "SupplierProductFeatures",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProductPrices_SupplierProductFeatureId",
                table: "SupplierProductPrices",
                column: "SupplierProductFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProductSupplyContracts_ProductId",
                table: "SupplierProductSupplyContracts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProductSupplyContracts_SupplierId",
                table: "SupplierProductSupplyContracts",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPurchaseServiceAgreements_PurchasingDepartmentPriceId",
                table: "SupplierPurchaseServiceAgreements",
                column: "PurchasingDepartmentPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPurchaseServiceAgreements_SupplierId",
                table: "SupplierPurchaseServiceAgreements",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalAmountPayables_CostId",
                table: "TotalAmountPayables",
                column: "CostId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalAmountPayables_SupplierProductPriceId",
                table: "TotalAmountPayables",
                column: "SupplierProductPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DealerBankAccounts");

            migrationBuilder.DropTable(
                name: "SupplierProductSupplyContracts");

            migrationBuilder.DropTable(
                name: "SupplierPurchaseServiceAgreements");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "FinanceDepartments");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "PaymentConfirmations");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PurchasingDepartmentPrices");

            migrationBuilder.DropTable(
                name: "CustomerBankAccounts");

            migrationBuilder.DropTable(
                name: "DealerPayments");

            migrationBuilder.DropTable(
                name: "ProductDeliveries");

            migrationBuilder.DropTable(
                name: "TotalAmountPayables");

            migrationBuilder.DropTable(
                name: "CustomerPayments");

            migrationBuilder.DropTable(
                name: "Costs");

            migrationBuilder.DropTable(
                name: "SupplierProductPrices");

            migrationBuilder.DropTable(
                name: "Buys");

            migrationBuilder.DropTable(
                name: "SupplierProductFeatures");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OfferForSales");

            migrationBuilder.DropTable(
                name: "PurchasingDepartments");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "DealerProductSales");

            migrationBuilder.DropTable(
                name: "DealerProductFeatureSuggestions");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "DealerProductDemands");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Dealers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
