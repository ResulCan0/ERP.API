namespace ERP.Entities.Models;

public class PaymentConfirmation : IEntity
{
    #region Primary Key

    public int PaymentConfirmationId { get; set; }

    #endregion

    #region Columns

    public bool Accepted { get; set; }
    
    public int CustomerBankAccountId { get; set; }

    #endregion

    #region Foreign Key

    public CustomerBankAccount CustomerBankAccount { get; set; }

    public ICollection<FinanceDepartment> FinanceDepartment { get; set; }

    #endregion
}