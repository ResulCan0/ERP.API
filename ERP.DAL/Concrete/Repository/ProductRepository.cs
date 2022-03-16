using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class ProductRepository : EfEntityRepositoryBase<Product, ERPDbContext>, IProductRepository
{
    public ProductRepository(ERPDbContext context) : base(context)
    {
    }
}