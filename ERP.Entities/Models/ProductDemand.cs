namespace ERP.Entities.Models;

public class ProductDemand : IEntity
{
    #region Primary Key

    public int DemandId { get; set; }

    #endregion

    #region Columns

    #endregion

    #region Foreign Keys

    public Product Product { get; set; }

    #endregion


}