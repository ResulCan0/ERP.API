using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class SupplierProductPriceRepository: EfEntityRepositoryBase<SupplierProductPrice, ERPDbContext>, ISupplierProductPriceRepository
{
    public SupplierProductPriceRepository(ERPDbContext context) : base(context)
    {
    }
}