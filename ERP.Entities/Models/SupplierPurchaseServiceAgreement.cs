namespace ERP.Entities.Models;

public class SupplierPurchaseServiceAgreement : IEntity
{
    #region Primary Key

    public int SupplierPurchaseServiceAgreementId { get; set; }

    #endregion

    #region Columns

    public bool IsSigned { get; set; }

    public int SupplierId { get; set; }
    
    public int PurchasingDepartmentPriceId { get; set; }
    public DateTime SignedDate { get; set; }

    public DateTime SignedEndDate { get; set; }

    #endregion

    #region Foreign Key

    public Supplier Supplier { get; set; }

    public PurchasingDepartmentPrice PurchasingDepartmentPrice { get; set; }

    #endregion
}