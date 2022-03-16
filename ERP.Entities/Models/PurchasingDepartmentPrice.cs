namespace ERP.Entities.Models;

public class PurchasingDepartmentPrice : IEntity
{
    #region Primary Key

    public int PurchasingDepartmentPriceId { get; set; }

    #endregion

    #region Columns

    public bool Accepted { get; set; }
    
    public int TotalAmountPayableId { get; set; }

    #endregion

    #region Foreign Key

    public TotalAmountPayable TotalAmountPayable { get; set; }

    public ICollection<FinanceDepartment> FinanceDepartment { get; set; }

    public ICollection<SupplierPurchaseServiceAgreement> SupplierPurchaseServiceAgreement { get; set; }

    #endregion
}