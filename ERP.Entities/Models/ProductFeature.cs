namespace ERP.Entities.Models;

public class ProductFeature : IEntity
{
    #region Primary Key

    public int ProductFeatureId { get; set; }

    #endregion

    #region Columns

    public int Appearance { get; set; }

    public int Availabiliyt { get; set; }

    public int Functionality { get; set; }

    public int Innovation { get; set; }

    public int PriceAdvantage { get; set; }

    public int CriterionNote { get; set; }

    #endregion

    #region Foreing Key

    public ICollection<DealerProductFeatureSuggestion> DealerProductFeatureSuggestion { get; set; }

    public ICollection<SupplierProductFeature> SupplierProductFeature { get; set; }

    #endregion
}