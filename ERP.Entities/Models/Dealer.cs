namespace ERP.Entities.Models;

public class Dealer : IEntity
{
    #region Primary Key
    public int DealerId { get; set; }

    #endregion

    #region Columns

    public string DealerName { get; set; }
    public string DealerAddress { get; set; }

    #endregion

    #region Foreign Keys
    public User User { get; set; }
    
    public ICollection<Stock> Stock { get; set; }  
    #endregion
}