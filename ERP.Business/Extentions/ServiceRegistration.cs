using ERP.DAL.Concrete.EntityFramework.Context;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using ERP.Business.Extentions;
using ERP.DAL.Abstract;
using ERP.DAL.Concrete.Repository;
using ERP.Entities.Models;
using Microsoft.AspNetCore.Http;

namespace ERP.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterDatabase(this IServiceCollection services,
            IConfiguration configuration)
        {
            return services.AddDbContext<ERPDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlConStr"),
                    sqlOptions =>
                    {
                        sqlOptions
                            .EnableRetryOnFailure(
                                maxRetryCount: 1,
                                maxRetryDelay: TimeSpan.FromSeconds(10),
                                errorNumbersToAdd: null);
                    });
                // options.EnableSensitiveDataLogging();
                // options.EnableDetailedErrors();
            }, ServiceLifetime.Transient, ServiceLifetime.Singleton);
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            return services
                .AddTransient<ExceptionMiddleware>()
                .AddTransient<IBuyRepository, BuyRepository>()
                .AddTransient<ICostRepository, CostRepository>()
                .AddTransient<ICustomerRepository, CustomerRepository>()
                .AddTransient<ICustomerBankAccountRepository, CustomerBankAccountRepository>()
                .AddTransient<ICustomerPaymentRepository, CustomerPaymentRepository>()
                .AddTransient<IDealerRepository, DealerRepository>()
                .AddTransient<IDealerBankAccountRepository, DealerBankAccountRepository>()
                .AddTransient<IDealerPaymentRepository, DealerPaymentRepository>()
                .AddTransient<IDealerProductDemandRepository, DealerProductDemandRepository>()
                .AddTransient<IDealerProductFeatureSuggestionRepository, DealerProductFeatureSuggestionRepository>()
                .AddTransient<IDealerProductSaleRepository, DealerProductSaleRepository>()
                .AddTransient<IFinanceDepartmentRepository, FinanceDepartmentRepository>()
                .AddTransient<IOfferForSaleRepository, OfferForSaleRepository>()
                .AddTransient<IPaymentRepository, PaymentRepository>()
                .AddTransient<IProductRepository, ProductRepository>()
                .AddTransient<IProductDeliveryRepository, ProductDeliveryRepository>()
                .AddTransient<IProductFeaturesRepository, ProductFeaturesRepository>()
                .AddTransient<IPurchasingDepartmentRepository, PurchasingDepartmentRepository>()
                .AddTransient<IPurchasingDepartmentPriceRepository, PurchasingDepartmentPriceRepository>()
                .AddTransient<IRoleRepository, RoleRepository>()
                .AddTransient<IStockRepository, StockRepository>()
                .AddTransient<ISupplierRepository, SupplierRepository>()
                .AddTransient<ISupplierProductFeatureRepository, SupplierProductFeatureRepository>()
                .AddTransient<ISupplierProductPriceRepository, SupplierProductPriceRepository>()
                .AddTransient<ISupplierProductSupplyContractRepository, SupplierProductSupplyContractRepository>()
                .AddTransient<ISupplierPurchaseServiceAgreementRepository, SupplierPurchaseServiceAgreementRepository>()
                .AddTransient<ITotalAmountPayableRepository, TotalAmountPayableRepository>()
                .AddTransient<IUserRepository, UserRepository>();
        }

        public static void AddBusinessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly())
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}