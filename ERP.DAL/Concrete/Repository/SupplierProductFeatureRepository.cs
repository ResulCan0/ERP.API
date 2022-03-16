using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class SupplierProductFeatureRepository: EfEntityRepositoryBase<SupplierProductFeature, ERPDbContext>, ISupplierProductFeatureRepository
{
    public SupplierProductFeatureRepository(ERPDbContext context) : base(context)
    {
    }
}