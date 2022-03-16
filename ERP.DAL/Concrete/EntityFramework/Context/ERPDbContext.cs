
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.EntityFramework.Context
{
    public class ERPDbContext: DbContext
    {
        protected readonly IConfiguration _configuration;

        public ERPDbContext(IConfiguration configuration) { _configuration = configuration; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlConStr"));
        }
        
        public virtual DbSet<Buy> Buys { get; set; }
        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerBankAccount> CustomerBankAccounts { get; set; }
        public virtual DbSet<CustomerPayment> CustomerPayments { get; set; }
        public virtual DbSet<Dealer> Dealers { get; set; }
        public virtual DbSet<DealerBankAccount> DealerBankAccounts { get; set; }
        public virtual DbSet<DealerPayment> DealerPayments { get; set; }
        public virtual DbSet<DealerProductDemand> DealerProductDemands { get; set; }
        public virtual DbSet<DealerProductFeatureSuggestion> DealerProductFeatureSuggestions { get; set; }
        public virtual DbSet<DealerProductSale> DealerProductSales { get; set; }
        public virtual DbSet<FinanceDepartment> FinanceDepartments { get; set; }
        public virtual DbSet<OfferForSale> OfferForSales { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentConfirmation> PaymentConfirmations { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDelivery> ProductDeliveries { get; set; }
        public virtual DbSet<ProductFeature> ProductFeatures { get; set; }
        public virtual DbSet<PurchasingDepartment> PurchasingDepartments { get; set; }
        public virtual DbSet<PurchasingDepartmentPrice> PurchasingDepartmentPrices { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierProductFeature> SupplierProductFeatures { get; set; }
        public virtual DbSet<SupplierProductPrice> SupplierProductPrices { get; set; }
        public virtual DbSet<SupplierProductSupplyContract> SupplierProductSupplyContracts { get; set; }
        public virtual DbSet<SupplierPurchaseServiceAgreement> SupplierPurchaseServiceAgreements { get; set; }
        public virtual DbSet<TotalAmountPayable> TotalAmountPayables { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
