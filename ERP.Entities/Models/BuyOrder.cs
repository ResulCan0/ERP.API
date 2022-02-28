namespace ERP.Entities.Models;

public class BuyOrder : IEntity
{
    #region Primary Key

    public int OrderId { get; set; }

    #endregion

    #region Columns

    #endregion

    #region Foreign Key
    public SupplyTermsContract SupplyTermsContract { get; set; }

    public ICollection<Bid> Bid { get; set; }
    #endregion

}