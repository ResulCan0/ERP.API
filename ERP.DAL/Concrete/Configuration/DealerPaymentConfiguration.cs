using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class DealerPaymentConfiguration : IEntityTypeConfiguration<DealerPayment>
{
    public void Configure(EntityTypeBuilder<DealerPayment> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.DealerPaymentId);
        builder.Property(_ => _.DealerPaymentId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.PaymentStatus).HasMaxLength(1);
        builder.Property(_ => _.AmountPay).HasPrecision(18, 2);

        #region DealerID --> DealerID

        builder.Property(_ => _.DealerId);
        builder
            .HasOne(_ => _.Dealer)
            .WithMany(c => c.DealerPayment)
            .HasForeignKey(fk => fk.DealerId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}