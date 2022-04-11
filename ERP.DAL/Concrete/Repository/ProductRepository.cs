using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.DTOs;
using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP.DAL.Concrete.Repository;

public class ProductRepository : EfEntityRepositoryBase<Product, ERPDbContext>, IProductRepository
{
    public ProductRepository(ERPDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<GetProductNameDto>> GetByProductName(string name)
    {
        var result = await (from product in Context.Products
            where product.Name == name
            select new GetProductNameDto()
            {
                Name = name
            }).ToListAsync();

        return result;
    }
}