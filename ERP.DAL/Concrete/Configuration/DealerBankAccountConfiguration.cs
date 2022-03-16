using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class DealerBankAccountConfiguration : IEntityTypeConfiguration<DealerBankAccount>
{
    public void Configure(EntityTypeBuilder<DealerBankAccount> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.DealerBankAccountId);
        builder.Property(_ => _.DealerBankAccountId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.AccountNumber).HasMaxLength(8).IsRequired();
        builder.Property(_ => _.MoneyInAccount).HasPrecision(18, 2).IsRequired();

        #region DealerID --> DealerID

        builder.Property(_ => _.DealerId);
        builder
            .HasOne(_ => _.Dealer)
            .WithMany(c => c.DealerBankAccount)
            .HasForeignKey(fk => fk.DealerId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion
        #region FinanceDepartmentID --> FinanceDepartmentID

        builder.Property(_ => _.FinanceDepartmentId);
        builder
            .HasOne(_ => _.FinanceDepartment)
            .WithMany(c => c.DealerBankAccount)
            .HasForeignKey(fk => fk.FinanceDepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}