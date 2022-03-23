namespace ERP.Entities.Models;

public class Supplier : IEntity
{
    #region Primary Key

    public int SupplierId { get; set; }

    #endregion

    #region Columns

    public string Name { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    #endregion

    #region Foreing Key

    public ICollection<SupplierProductFeature> SupplierProductFeature { get; set; }

    public ICollection<SupplierProductSupplyContract> SupplierProductSupplyContract { get; set; }

    public ICollection<SupplierPurchaseServiceAgreement> SupplierPurchaseServiceAgreement { get; set; }

    #endregion
}