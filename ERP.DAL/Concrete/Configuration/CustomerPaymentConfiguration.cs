using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class CustomerPaymentConfiguration : IEntityTypeConfiguration<CustomerPayment>
{
    public void Configure(EntityTypeBuilder<CustomerPayment> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.CustomerPaymentId);
        builder.Property(_ => _.CustomerPaymentId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Status).HasMaxLength(1);
        builder.Property(_ => _.AmountPay).HasPrecision(18, 2);

        #region BuyID --> BuyID

        builder.Property(_ => _.BuyId);
        builder
            .HasOne(_ => _.Buy)
            .WithMany(c => c.CustomerPayment)
            .HasForeignKey(fk => fk.BuyId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}