using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Models;
public class Product : IEntity
{
    #region Primary Key
    public int ProductId { get; set; }
    #endregion

    #region Columns
    public string ProductName { get; set; }

    #endregion
    
    #region Foreign Key 
    public ICollection<ProductDemand> ProductDemand { get; set; }
    public ICollection<Stock> Stock { get; set; }  
    #endregion
}
