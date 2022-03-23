using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class DealerProductDemandRepository: EfEntityRepositoryBase<DealerProductDemand, ERPDbContext>, IDealerProductDemandRepository
{
    public DealerProductDemandRepository(ERPDbContext context) : base(context)
    {
        
    }
}