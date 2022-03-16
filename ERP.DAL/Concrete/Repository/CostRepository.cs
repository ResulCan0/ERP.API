using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class CostRepository: EfEntityRepositoryBase<Cost, ERPDbContext>, ICostRepository
{
    public CostRepository(ERPDbContext context) : base(context)
    {
    }
}