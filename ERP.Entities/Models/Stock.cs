namespace ERP.Entities.Models;

public class Stock : IEntity
{
    #region Primary Key

    public int Id { get; set; }

    #endregion

    #region Columns

    public int Quantity { get; set; }

    #endregion

    #region Foreign Keys

    public int QualityDetailID { get; set; }
    public int ProductId { get; set; }
    public int DealerID { get; set; }

    #endregion

    public ProductQualityDetails ProductQualityDetails { get; set; }
    public Product Product { get; set; }
    public Dealer Dealer { get; set; }
}