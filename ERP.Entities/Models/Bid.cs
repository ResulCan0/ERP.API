namespace ERP.Entities.Models;

public class Bid : IEntity
{
    #region Primary Key

    public int BidId { get; set; }

    #endregion

    #region Columns

    public double Price { get; set; }

    #endregion

    #region Foreign Keys
    public BuyOrder BuyOrder { get; set; }

    #endregion
}