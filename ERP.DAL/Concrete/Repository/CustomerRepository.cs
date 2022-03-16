using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class CustomerRepository : EfEntityRepositoryBase<Customer, ERPDbContext>, ICustomerRepository
{
    public CustomerRepository(ERPDbContext context) : base(context)
    {
    }
}