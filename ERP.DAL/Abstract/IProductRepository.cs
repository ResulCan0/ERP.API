using ERP.DAL.Concrete.EntityFramework;
using ERP.Entities.DTOs;
using ERP.Entities.Models;

namespace ERP.DAL.Abstract;

public interface IProductRepository:IEntityRepository<Product>
{
    Task<IEnumerable<GetProductNameDto>> GetByProductName(string name);
}