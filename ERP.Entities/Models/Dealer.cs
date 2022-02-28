namespace ERP.Entities.Models;

public class Dealer : IEntity
{
    #region Primary Key
    #endregion

    #region Columns

    public string DealerName { get; set; }
    public string DealerAddress { get; set; }

    #endregion

    #region Foreign Keys

    public int DealerId { get; set; }

    #endregion

    public User User { get; set; }
}