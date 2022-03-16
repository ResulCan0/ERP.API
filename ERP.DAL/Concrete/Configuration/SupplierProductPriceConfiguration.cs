using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class SupplierProductPriceConfiguration : IEntityTypeConfiguration<SupplierProductPrice>
{
    public void Configure(EntityTypeBuilder<SupplierProductPrice> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.SupplierProductPriceId);
        builder.Property(_ => _.SupplierProductPriceId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Price).HasPrecision(18, 2).IsRequired();

        #region SupplierProductFeatureID --> SupplierProductFeatureID

        builder.Property(_ => _.SupplierProductFeatureId);
        builder
            .HasOne(_ => _.SupplierProductFeature)
            .WithMany(c => c.SupplierProductPrice)
            .HasForeignKey(fk => fk.SupplierProductFeatureId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}