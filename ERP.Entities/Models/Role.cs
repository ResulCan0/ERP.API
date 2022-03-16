namespace ERP.Entities.Models;

public class Role : IEntity
{
    #region Primary Key

    public int RoleId { get; set; }

    #endregion

    #region Columns

    public string Name { get; set; }

    #endregion

    #region Foreing Key

    public ICollection<User> User { get; set; }

    #endregion
}