namespace ERP.Entities.Models;

public class ProductQualityDetails : IEntity
{
    #region Primary Key

    public int QualityDetailId { get; set; }

    #endregion

    #region Columns

    public int Aesthetic { get; set; }
    public int Usability { get; set; }
    public int Innovation { get; set; }
    public int Price { get; set; }

    #endregion

    #region Foreign Keys

    #endregion
}