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
}
