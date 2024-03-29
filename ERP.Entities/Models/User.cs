﻿namespace ERP.Entities.Models;

public class User : IEntity
{
    #region Primary Key

    public int UserId { get; set; }

    #endregion

    #region Columns

    public string UserName { get; set; }

    public int RoleId { get; set; }

    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }

    #endregion

    #region Foreing Key

    public Role Role { get; set; }

    #endregion
}