using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class PaymentConfirmationConfiguration : IEntityTypeConfiguration<PaymentConfirmation>
{
    public void Configure(EntityTypeBuilder<PaymentConfirmation> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.PaymentConfirmationId);
        builder.Property(_ => _.PaymentConfirmationId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Accepted);

        #region CustomerBankAccountID --> CustomerBankAccountID

        builder.Property(_ => _.CustomerBankAccountId);
        builder
            .HasOne(_ => _.CustomerBankAccount)
            .WithMany(c => c.PaymentConfirmation)
            .HasForeignKey(fk => fk.CustomerBankAccountId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}