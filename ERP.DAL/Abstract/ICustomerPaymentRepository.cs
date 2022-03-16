﻿using ERP.DAL.Concrete.EntityFramework;
using ERP.Entities.Models;

namespace ERP.DAL.Abstract;

public interface ICustomerPaymentRepository : IEntityRepository<CustomerPayment>
{
    
}