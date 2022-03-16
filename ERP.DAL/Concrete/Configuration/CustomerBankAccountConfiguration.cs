using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class CustomerBankAccountConfiguration : IEntityTypeConfiguration<CustomerBankAccount>
{
    public void Configure(EntityTypeBuilder<CustomerBankAccount> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.CustomerBankAccountId);
        builder.Property(_ => _.CustomerBankAccountId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.AccountNumber).HasMaxLength(8).IsRequired();
        builder.Property(_ => _.MoneyInAccount).HasPrecision(18, 2).IsRequired();

        #region CustomerID --> CustomerID

        builder.Property(_ => _.CustomerId);
        builder
            .HasOne(_ => _.Customer)
            .WithMany(c => c.CustomerBankAccount)
            .HasForeignKey(fk => fk.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region CustomerPaymentID --> CustomerPaymentID

        builder.Property(_ => _.CustomerPaymentId);
        builder
            .HasOne(_ => _.CustomerPayment)
            .WithMany(c => c.CustomerBankAccount)
            .HasForeignKey(fk => fk.CustomerPaymentId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}