namespace ERP.Entities.Models;

public class DealerProductSale : IEntity
{
    #region Primary Key

    public int DealerProductSaleId { get; set; }

    #endregion

    #region Columns

    public decimal Price { get; set; }
    
    public int StockId { get; set; }

    #endregion

    #region Foreign Key

    public Stock Stock { get; set; }

    public ICollection<OfferForSale> OfferForSale { get; set; }

    #endregion
}