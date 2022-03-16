using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class RoleRepository: EfEntityRepositoryBase<Role, ERPDbContext>, IRoleRepository
{
    public RoleRepository(ERPDbContext context) : base(context)
    {
    }
}