using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class SupplierRepository : EfEntityRepositoryBase<Supplier, ERPDbContext>, ISupplierRepository
{
    public SupplierRepository(ERPDbContext context) : base(context)
    {
    }
}