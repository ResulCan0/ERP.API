using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class FinanceDepartmentConfiguration : IEntityTypeConfiguration<FinanceDepartment>
{
    public void Configure(EntityTypeBuilder<FinanceDepartment> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.FinanceDepartmentId);
        builder.Property(_ => _.FinanceDepartmentId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.EmployeePayment).HasPrecision(18, 2).IsRequired();

        #region PaymentID --> PaymentID

        builder.Property(_ => _.PaymentId);
        builder
            .HasOne(_ => _.Payment)
            .WithMany(c => c.FinanceDepartment)
            .HasForeignKey(fk => fk.PaymentId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region PurchasingDepartmentPriceID --> PurchasingDepartmentPriceID

        builder.Property(_ => _.PurchasingDepartmentPriceId);
        builder
            .HasOne(_ => _.PurchasingDepartmentPrice)
            .WithMany(c => c.FinanceDepartment)
            .HasForeignKey(fk => fk.PurchasingDepartmentPriceId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region PaymentConfirmationID --> PaymentConfirmationID

        builder.Property(_ => _.PaymentConfirmationId);
        builder
            .HasOne(_ => _.PaymentConfirmation)
            .WithMany(c => c.FinanceDepartment)
            .HasForeignKey(fk => fk.PaymentConfirmationId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}