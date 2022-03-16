namespace ERP.Entities.Models;

public class SupplierProductFeature : IEntity
{
    #region Primary Key

    public int SupplierProductFeatureId { get; set; }

    #endregion

    #region Columns

    public int ProductFeatureId { get; set; }

    public int SupplierId { get; set; }

    public int PurchasingDepartmentId { get; set; }

    #endregion

    #region Foreign Key

    public Supplier Supplier { get; set; }

    public PurchasingDepartment PurchasingDepartment { get; set; }

    public ProductFeature ProductFeature { get; set; }

    public ICollection<SupplierProductPrice> SupplierProductPrice { get; set; }

    #endregion
}