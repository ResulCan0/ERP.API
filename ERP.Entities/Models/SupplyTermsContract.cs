namespace ERP.Entities.Models;

public class SupplyTermsContract : IEntity
{
    #region Primary Key

    public int SupplyTermsContractId { get; set; }

    #endregion

    #region Columns

    public bool IsSigned { get; set; }

    #endregion

    #region Foreign Keys
    public ICollection<BuyOrder> BuyOrder { get; set; }

    #endregion


}