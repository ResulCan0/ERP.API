namespace ERP.Entities.Models;

public class Buy : IEntity
{
    #region Primary Key

    public int BuyId { get; set; }

    #endregion

    #region Columns

    public string Amount { get; set; }
    
    public int OfferForSaleId { get; set; }
    public int CustomerId { get; set; }

    #endregion

    #region Foreign Key

    public OfferForSale OfferForSale { get; set; }

    public Customer Customer { get; set; }

    public ICollection<CustomerPayment> CustomerPayment { get; set; }

    #endregion
}