namespace ERP.Entities.Models;

public class TotalAmountPayable : IEntity
{
    #region Primary Key

    public int TotalAmountPayableId { get; set; }

    #endregion

    #region Columns

    public decimal TotalAmountPayablePrice { get; set; }

    public int CostId { get; set; }
    public int SupplierProductPriceId { get; set; }

    #endregion

    #region Foreign Key

    public Cost Cost { get; set; }

    public SupplierProductPrice SupplierProductPrice { get; set; }

    public ICollection<PurchasingDepartmentPrice> PurchasingDepartmentPrice { get; set; }

    #endregion
}