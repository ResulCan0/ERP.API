namespace ERP.Entities.Models;

public class SupplierProductSupplyContract : IEntity
{
    #region Primary Key

    public int SupplierProductSupplyContractId { get; set; }

    #endregion

    #region Columns

    public bool IsSigned { get; set; }
    public int SupplierId { get; set; }
    public int ProductId { get; set; }

    public DateTime SignedDate { get; set; }

    public DateTime SignedEndDate { get; set; }

    #endregion

    #region Foreign Key

    public Supplier Supplier { get; set; }

    public Product Product { get; set; }

    #endregion
}