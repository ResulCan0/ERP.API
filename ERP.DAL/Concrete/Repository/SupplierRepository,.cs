using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class SupplierRepository_:EfEntityRepositoryBase<Supplier,ERPDbContext>,ISupplierRepository
{
    public SupplierRepository_(ERPDbContext context) : base(context)
    {
    }
}