using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class CustomerBankAccountRepository: EfEntityRepositoryBase<CustomerBankAccount, ERPDbContext>, ICustomerBankAccountRepository
{
    public CustomerBankAccountRepository(ERPDbContext context) : base(context)
    {
    }
}