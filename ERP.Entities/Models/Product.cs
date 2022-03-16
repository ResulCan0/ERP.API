namespace ERP.Entities.Models;

public class Product : IEntity
{
    #region Primary Key

    public int ProductId { get; set; }

    #endregion

    #region Columns

    public string Name { get; set; }

    #endregion

    #region Foreing Key

    public ICollection<Stock> Stock { get; set; }

    public ICollection<DealerProductDemand> DealerProductDemand { get; set; }

    public ICollection<SupplierProductSupplyContract> SupplierProductSupplyContract { get; set; }

    #endregion
}