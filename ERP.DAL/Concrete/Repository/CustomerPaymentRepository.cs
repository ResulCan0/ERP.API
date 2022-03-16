using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class CustomerPaymentRepository: EfEntityRepositoryBase<CustomerPayment, ERPDbContext>, ICustomerPaymentRepository
{
    public CustomerPaymentRepository(ERPDbContext context) : base(context)
    {
    }
}