using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class PaymentConfirmationRepository : EfEntityRepositoryBase<PaymentConfirmation, ERPDbContext>, IPaymentConfirmationRepository
{
    public PaymentConfirmationRepository(ERPDbContext context) : base(context)
    {
    }
}