namespace ERP.Entities.Models;

public class DealerBankAccount : IEntity
{
    #region Primary Key

    public int DealerBankAccountId { get; set; }

    #endregion

    #region Columns

    public int AccountNumber { get; set; }
    
    public int DealerId { get; set; }
    
    public int FinanceDepartmentId { get; set; }

    public decimal MoneyInAccount { get; set; }

    #endregion

    #region Foreign Key

    public FinanceDepartment FinanceDepartment { get; set; }

    public Dealer Dealer { get; set; }

    #endregion
}