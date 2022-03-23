using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.DAL.Migrations
{
    public partial class Initial_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PriceAdvantage",
                table: "ProductFeatures",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Innovation",
                table: "ProductFeatures",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Functionality",
                table: "ProductFeatures",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "CriterionNote",
                table: "ProductFeatures",
                type: "decimal(2,2)",
                precision: 2,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 2,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Availabiliyt",
                table: "ProductFeatures",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Appearance",
                table: "ProductFeatures",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Dealers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Amount",
                table: "DealerProductDemands",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "DealerBankAccounts",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "CustomerBankAccounts",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Amount",
                table: "Buys",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "int",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "PriceAdvantage",
                table: "ProductFeatures",
                type: "int",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Innovation",
                table: "ProductFeatures",
                type: "int",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Functionality",
                table: "ProductFeatures",
                type: "int",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "CriterionNote",
                table: "ProductFeatures",
                type: "int",
                precision: 2,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Availabiliyt",
                table: "ProductFeatures",
                type: "int",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Appearance",
                table: "ProductFeatures",
                type: "int",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Dealers",
                type: "int",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "DealerProductDemands",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "AccountNumber",
                table: "DealerBankAccounts",
                type: "int",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Customers",
                type: "int",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<int>(
                name: "AccountNumber",
                table: "CustomerBankAccounts",
                type: "int",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Buys",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
