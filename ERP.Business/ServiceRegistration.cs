using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.DAL.Concrete.Repository;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ERP.Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterDatabase(this IServiceCollection services, IConfiguration configuration)
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
            return services.AddTransient<IProductRepository, ProductRepository>()
                .AddTransient<IBuyOrderRepository, BuyOrderRepository>()
                .AddTransient<ISupplyTermsContractRepository, SupplyTermsContractRepository>();


        }
        public static void AddBusinessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly())
                 .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
