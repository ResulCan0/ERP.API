namespace ERP.Entities.Models;

public class DealerProductFeatureSuggestion : IEntity
{
    #region Primary Key

    public int DealerProductFeatureSuggestionId { get; set; }

    #endregion

    #region Columns

    public int DealerProductDemandId { get; set; }
    
    public int ProductFeaturesId { get; set; }

    #endregion

    #region Foreing Key

    public ProductFeature ProductFeatures { get; set; }

    public DealerProductDemand DealerProductDemand { get; set; }

    public ICollection<PurchasingDepartment> PurchasingDepartment { get; set; }

    #endregion
}