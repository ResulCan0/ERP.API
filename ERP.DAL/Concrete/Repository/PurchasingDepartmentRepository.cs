using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class PurchasingDepartmentRepository : EfEntityRepositoryBase<PurchasingDepartment, ERPDbContext>, IPurchasingDepartmentRepository
{
    public PurchasingDepartmentRepository(ERPDbContext context) : base(context)
    {
    }
}