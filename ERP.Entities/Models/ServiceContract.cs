namespace ERP.Entities.Models;

public class ServiceContract : IEntity
{
    #region Primary Key

    public int ServiceContractId { get; set; }

    #endregion

    #region Columns

    public int SupplierId { get; set; }
    public bool IsSıgned { get; set; }

    #endregion

    #region Foreign Keys

    public Supplier Supplier { get; set; }
    #endregion
}