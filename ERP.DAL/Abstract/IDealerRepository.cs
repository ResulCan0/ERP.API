using ERP.DAL.Concrete.EntityFramework;
using ERP.Entities.DTOs;
using ERP.Entities.Models;

namespace ERP.DAL.Abstract;

public interface IDealerRepository:IEntityRepository<Dealer>
{
    Task<IEnumerable<GetDealerNameDto>> GetByUsername(string name);

}