using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class SupplierProductFeatureConfiguration : IEntityTypeConfiguration<SupplierProductFeature>
{
    public void Configure(EntityTypeBuilder<SupplierProductFeature> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.SupplierProductFeatureId);
        builder.Property(_ => _.SupplierProductFeatureId).UseIdentityColumn();

        #endregion

        #region Columns

        #region ProductFeatureID --> ProductFeatureID

        builder.Property(_ => _.ProductFeatureId);
        builder
            .HasOne(_ => _.ProductFeature)
            .WithMany(c => c.SupplierProductFeature)
            .HasForeignKey(fk => fk.ProductFeatureId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region SupplierID --> SupplierID

        builder.Property(_ => _.SupplierId);
        builder
            .HasOne(_ => _.Supplier)
            .WithMany(c => c.SupplierProductFeature)
            .HasForeignKey(fk => fk.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region PurchasingDepartmentID --> PurchasingDepartmentID

        builder.Property(_ => _.PurchasingDepartmentId);
        builder
            .HasOne(_ => _.PurchasingDepartment)
            .WithMany(c => c.SupplierProductFeature)
            .HasForeignKey(fk => fk.PurchasingDepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}