﻿using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAL.Concrete.Repository
{
    public class UserRepository : EfEntityRepositoryBase<User, ERPDbContext>, IUserRepository
    {
        public UserRepository(ERPDbContext context) : base(context)
        {
        }
    }
}