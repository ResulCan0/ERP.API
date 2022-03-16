namespace ERP.Entities.Models;

public class FinanceDepartment : IEntity
{
    #region Primary Key

    public int FinanceDepartmentId { get; set; }

    #endregion

    #region Columns

    public decimal EmployeePayment { get; set; }

    public int PaymentId { get; set; }
    
    public int PurchasingDepartmentPriceId { get; set; }
    
    public int PaymentConfirmationId { get; set; }

    #endregion

    #region Foreign Key

    public PurchasingDepartmentPrice PurchasingDepartmentPrice { get; set; }

    public Payment Payment { get; set; }

    public PaymentConfirmation PaymentConfirmation { get; set; }

    public ICollection<DealerBankAccount> DealerBankAccount { get; set; }

    #endregion
}