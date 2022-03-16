namespace ERP.Entities.Models;

public class Stock : IEntity
{
    #region Primary Key

    public int StockId { get; set; }

    #endregion

    #region Columns

    public int Amount { get; set; }
    
    public int ProductId { get; set; }
    
    public int DealerId { get; set; }

    #endregion

    #region Foreign Key

    public Product Product { get; set; }

    public Dealer Dealer { get; set; }

    public ICollection<DealerProductSale> DealerProductSale { get; set; }

    public ICollection<PurchasingDepartmentPrice> PurchasingDepartmentPrice { get; set; }

    #endregion
}