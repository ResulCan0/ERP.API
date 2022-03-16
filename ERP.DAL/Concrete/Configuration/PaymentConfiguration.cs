using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.PaymentId);
        builder.Property(_ => _.PaymentId).UseIdentityColumn();

        #endregion

        #region Columns

        #region DealerPaymentID --> DealerPaymentID

        builder.Property(_ => _.DealerPaymentId);
        builder
            .HasOne(_ => _.DealerPayment)
            .WithMany(c => c.Payment)
            .HasForeignKey(fk => fk.DealerPaymentId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region ProductDeliveryID --> ProductDeliveryID

        builder.Property(_ => _.ProductDeliveryId);
        builder
            .HasOne(_ => _.ProductDelivery)
            .WithMany(c => c.Payment)
            .HasForeignKey(fk => fk.ProductDeliveryId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}