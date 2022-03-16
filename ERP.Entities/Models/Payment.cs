namespace ERP.Entities.Models;

public class Payment : IEntity
{
    #region Primary Key

    public int PaymentId { get; set; }

    #endregion

    #region Columns

    public int DealerPaymentId { get; set; }
    
    public int ProductDeliveryId { get; set; }
    
    
    #endregion

    #region Foreign Key

    public DealerPayment DealerPayment { get; set; }

    public ProductDelivery ProductDelivery { get; set; }

    public ICollection<FinanceDepartment> FinanceDepartment { get; set; }

    #endregion
}