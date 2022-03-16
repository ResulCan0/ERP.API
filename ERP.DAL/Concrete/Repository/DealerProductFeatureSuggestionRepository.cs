using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.Models;

namespace ERP.DAL.Concrete.Repository;

public class DealerProductFeatureSuggestionRepository: EfEntityRepositoryBase<DealerProductFeatureSuggestion, ERPDbContext>, IDealerProductFeatureSuggestionRepository
{
    public DealerProductFeatureSuggestionRepository(ERPDbContext context) : base(context)
    {
    }
}