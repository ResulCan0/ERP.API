namespace ERP.Entities.Models;

public class ProductFeature : IEntity
{
    #region Primary Key

    public int ProductFeatureId { get; set; }

    #endregion

    #region Columns

    public string Appearance { get; set; }

    public string Availabiliyt { get; set; }

    public string Functionality { get; set; }

    public string Innovation { get; set; }

    public string PriceAdvantage { get; set; }

    public decimal CriterionNote { get; set; }

    #endregion

    #region Foreing Key

    public ICollection<DealerProductFeatureSuggestion> DealerProductFeatureSuggestion { get; set; }

    public ICollection<SupplierProductFeature> SupplierProductFeature { get; set; }

    #endregion
}