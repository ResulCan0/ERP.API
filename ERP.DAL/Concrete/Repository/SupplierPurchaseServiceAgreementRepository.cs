using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class SupplierPurchaseServiceAgreementRepository: EfEntityRepositoryBase<SupplierPurchaseServiceAgreement, ERPDbContext>, ISupplierPurchaseServiceAgreementRepository
{
    public SupplierPurchaseServiceAgreementRepository(ERPDbContext context) : base(context)
    {
    }
}