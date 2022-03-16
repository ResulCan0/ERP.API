namespace ERP.Entities.Models;

public class OfferForSale : IEntity
{
    #region Primary Key

    public int OfferForSaleId { get; set; }

    #endregion

    #region Columns

    public int DealerProductSaleId { get; set; }

    #endregion

    #region Foreign Key

    public DealerProductSale DealerProductSale { get; set; }

    public ICollection<Buy> Buy { get; set; }

    #endregion
}