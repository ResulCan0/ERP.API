namespace ERP.Entities.Models;

public class Supplier : IEntity
{
    #region Primary Key

    #endregion

    #region Columns

    public string SupplierName { get; set; }
    public string SupplierAddress { get; set; }
    public string SupplierPhone { get; set; }

    #endregion

    #region Foreign Keys

    public int SupplierId { get; set; }

    #endregion
    
    public User User { get; set; }
}