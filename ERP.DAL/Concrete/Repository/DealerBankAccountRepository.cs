using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class DealerBankAccountRepository: EfEntityRepositoryBase<DealerBankAccount, ERPDbContext>, IDealerBankAccountRepository
{
    public DealerBankAccountRepository(ERPDbContext context) : base(context)
    {
    }
}