namespace ERP.Entities.Models;

public class Dealer : IEntity
{
    #region Primary Key

    public int DealerId { get; set; }

    #endregion

    #region Columns

    public string Name { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    #endregion

    #region Foreing Key

    public ICollection<Stock> Stock { get; set; }

    public ICollection<DealerBankAccount> DealerBankAccount { get; set; }

    public ICollection<DealerPayment> DealerPayment { get; set; }

    public ICollection<DealerProductDemand> DealerProductDemand { get; set; }

    #endregion
}