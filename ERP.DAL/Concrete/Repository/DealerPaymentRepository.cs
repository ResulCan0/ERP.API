using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class DealerPaymentRepository: EfEntityRepositoryBase<DealerPayment, ERPDbContext>, IDealerPaymentRepository
{
    public DealerPaymentRepository(ERPDbContext context) : base(context)
    {
    }
}