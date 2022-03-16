using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class FinanceDepartmentRepository : EfEntityRepositoryBase<FinanceDepartment, ERPDbContext>, IFinanceDepartmentRepository
{
    public FinanceDepartmentRepository(ERPDbContext context) : base(context)
    {
    }
}