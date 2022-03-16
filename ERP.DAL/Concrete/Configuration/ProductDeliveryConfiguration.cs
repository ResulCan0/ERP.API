using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class ProductDeliveryConfiguration : IEntityTypeConfiguration<ProductDelivery>
{
    public void Configure(EntityTypeBuilder<ProductDelivery> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.ProductDeliveryId);
        builder.Property(_ => _.ProductDeliveryId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.DeliveryDate).IsRequired();
        builder.Property(_ => _.DueTime).IsRequired();

        #endregion
    }
}