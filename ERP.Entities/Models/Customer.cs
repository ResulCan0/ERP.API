namespace ERP.Entities.Models;

public class Customer : IEntity
{
    #region Primary Key

    public int CustomerId { get; set; }

    #endregion

    #region Columns

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Address { get; set; }

    public int PhoneNumber { get; set; }

    #endregion

    #region Foreing Key

    public ICollection<Buy> Buy { get; set; }

    public ICollection<CustomerBankAccount> CustomerBankAccount { get; set; }

    #endregion
}