namespace ERP.Entities.Models;

public class PurchasingDepartment : IEntity
{
    #region Primary Key

    public int PurchasingDepartmentId { get; set; }

    #endregion

    #region Columns

    public int DealerProductFeatureSuggestionId { get; set; }
    #endregion

    #region Foreing Key

    public DealerProductFeatureSuggestion DealerProductFeatureSuggestion { get; set; }

    public ICollection<SupplierProductFeature> SupplierProductFeature { get; set; }

    #endregion
}