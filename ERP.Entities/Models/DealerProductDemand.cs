namespace ERP.Entities.Models;

public class DealerProductDemand : IEntity
{
    #region Primary Key

    public int DealerProductDemandId { get; set; }

    #endregion

    #region Columns

    public string Amount { get; set; }
    public int DealerId { get; set; }
    
    public int ProductId { get; set; }

    #endregion

    #region Foreing Key

    public Product Product { get; set; }

    public Dealer Dealer { get; set; }

    public ICollection<DealerProductFeatureSuggestion> DealerProductFeatureSuggestion { get; set; }

    #endregion
}