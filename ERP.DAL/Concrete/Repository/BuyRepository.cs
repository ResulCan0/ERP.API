using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class BuyRepository : EfEntityRepositoryBase<Buy, ERPDbContext>, IBuyRepository
{
    public BuyRepository(ERPDbContext context) : base(context)
    {
    }
}