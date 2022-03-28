using ERP.DAL.Abstract;
using ERP.DAL.Concrete.EntityFramework;
using ERP.DAL.Concrete.EntityFramework.Context;
using ERP.Entities.DTOs;
using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP.DAL.Concrete.Repository;

public class DealerRepository: EfEntityRepositoryBase<Dealer, ERPDbContext>, IDealerRepository
{
    public DealerRepository(ERPDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<GetDealerNameDto>> GetByUsername(string name)
    {
        var result = await (from dealer in Context.Dealers
            where dealer.Name == name
            select new GetDealerNameDto()
            {
                Name = name
            }).ToListAsync();

        return result;
    }
}