namespace ERP.Entities.Models;

public class ProductDemand : IEntity
{
    #region Primary Key

    public int DemandId { get; set; }

    #endregion

    #region Columns

    #endregion

    #region Foreign Keys

    public int ProductId { get; set; }

    #endregion

    public Product Product { get; set; }
}