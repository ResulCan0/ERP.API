namespace ERP.Entities.Models;

public class DealerPayment : IEntity
{
    #region Primary Key

    public int DealerPaymentId { get; set; }

    #endregion

    #region Columns

    public int PaymentStatus { get; set; }
    public int DealerId { get; set; }

    public decimal AmountPay { get; set; }

    #endregion

    #region Foreign Key

    public Dealer Dealer { get; set; }

    public ICollection<Payment> Payment { get; set; }

    #endregion
}