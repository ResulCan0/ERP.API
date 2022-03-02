namespace ERP.Entities.Models;

public class Supplier : IEntity
{
    #region Primary Key

    public int SupplierId { get; set; }
    #endregion

    #region Columns

    public string SupplierName { get; set; }
    public string SupplierAddress { get; set; }
    public string SupplierPhone { get; set; }

    public bool IsServiceContractSigned { get; set; }

    #endregion

    #region Foreign Keys

    public User User { get; set; }

    public ICollection<ServiceContract> ServiceContract { get; set; }

    #endregion
    

}