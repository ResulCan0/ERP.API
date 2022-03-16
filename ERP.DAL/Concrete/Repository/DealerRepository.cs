﻿using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class DealerRepository: EfEntityRepositoryBase<Dealer, ERPDbContext>, IDealerRepository
{
    public DealerRepository(ERPDbContext context) : base(context)
    {
    }
}