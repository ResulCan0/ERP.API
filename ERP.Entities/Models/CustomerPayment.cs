namespace ERP.Entities.Models;

public class CustomerPayment : IEntity
{
    #region Primary Key

    public int CustomerPaymentId { get; set; }

    #endregion

    #region Columns

    public int Status { get; set; }
    
    public int BuyId { get; set; }

    public decimal AmountPay { get; set; }

    #endregion

    #region Foreign Key

    public Buy Buy { get; set; }

    public ICollection<CustomerBankAccount> CustomerBankAccount { get; set; }

    #endregion
}