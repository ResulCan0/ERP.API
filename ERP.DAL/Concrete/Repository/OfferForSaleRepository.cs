using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class OfferForSaleRepository : EfEntityRepositoryBase<OfferForSale, ERPDbContext>, IOfferForSaleRepository
{
    public OfferForSaleRepository(ERPDbContext context) : base(context)
    {
    }
}