namespace ERP.Entities.Models;

public class SupplierProductPrice : IEntity
{
    #region Primary Key

    public int SupplierProductPriceId { get; set; }

    #endregion

    #region Columns

    public decimal Price { get; set; }

    public int SupplierProductFeatureId { get; set; }

    #endregion

    #region Foreign Key

    public SupplierProductFeature SupplierProductFeature { get; set; }

    public ICollection<TotalAmountPayable> TotalAmountPayable { get; set; }

    #endregion
}