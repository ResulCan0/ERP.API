namespace ERP.Entities.Models;

public class ProductDelivery : IEntity
{
    #region Primary Key

    public int ProductDeliveryId { get; set; }

    #endregion

    #region Columns

    public DateTime DeliveryDate { get; set; }

    public DateTime DueTime { get; set; }

    #endregion

    #region Foreign Key

    public ICollection<Payment> Payment { get; set; }

    #endregion
}