namespace ERP.Entities.Models;

public class Cost : IEntity
{
    #region Primary Key

    public int CostId { get; set; }

    #endregion

    #region Columns

    public decimal ShippingCost { get; set; }

    public decimal FirmCost { get; set; }

    public decimal BankCommission { get; set; }

    #endregion

    #region Foreign Key

    public ICollection<TotalAmountPayable> TotalAmountPayable { get; set; }

    #endregion
}