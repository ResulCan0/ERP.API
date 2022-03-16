using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class SupplierPurchaseServiceAgreementConfiguration : IEntityTypeConfiguration<SupplierPurchaseServiceAgreement>
{
    public void Configure(EntityTypeBuilder<SupplierPurchaseServiceAgreement> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.SupplierPurchaseServiceAgreementId);
        builder.Property(_ => _.SupplierPurchaseServiceAgreementId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.IsSigned);
        builder.Property(_ => _.SignedDate).IsRequired();
        builder.Property(_ => _.SignedEndDate).IsRequired();

        #region SupplierID --> SupplierID

        builder.Property(_ => _.SupplierId);
        builder
            .HasOne(_ => _.Supplier)
            .WithMany(c => c.SupplierPurchaseServiceAgreement)
            .HasForeignKey(fk => fk.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region PurchasingDepartmentPriceID --> PurchasingDepartmentPriceID

        builder.Property(_ => _.PurchasingDepartmentPriceId);
        builder
            .HasOne(_ => _.PurchasingDepartmentPrice)
            .WithMany(c => c.SupplierPurchaseServiceAgreement)
            .HasForeignKey(fk => fk.PurchasingDepartmentPriceId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}