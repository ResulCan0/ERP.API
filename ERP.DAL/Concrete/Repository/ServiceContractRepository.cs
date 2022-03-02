using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class ServiceContractRepository:EfEntityRepositoryBase<ServiceContract,ERPDbContext>,IServiceContractRepository
{
    public ServiceContractRepository(ERPDbContext context) : base(context)
    {
    }
}