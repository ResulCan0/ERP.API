using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class DealerProductSaleRepository: EfEntityRepositoryBase<DealerProductSale, ERPDbContext>, IDealerProductSaleRepository
{
    public DealerProductSaleRepository(ERPDbContext context) : base(context)
    {
    }
}