using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class StockRepository:EfEntityRepositoryBase<Stock,ERPDbContext>,IStockRepository
{
    public StockRepository(ERPDbContext context) : base(context)
    {
    }
}