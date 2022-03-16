namespace ERP.Entities.Models;

public class CustomerBankAccount : IEntity
{
    #region Primary Key

    public int CustomerBankAccountId { get; set; }

    #endregion

    #region Columns

    public int AccountNumber { get; set; }

    public int CustomerId { get; set; }
    
    public int CustomerPaymentId { get; set; }
    public decimal MoneyInAccount { get; set; }

    #endregion

    #region Foreign Key

    public Customer Customer { get; set; }

    public CustomerPayment CustomerPayment { get; set; }

    public ICollection<PaymentConfirmation> PaymentConfirmation { get; set; }

    #endregion
}