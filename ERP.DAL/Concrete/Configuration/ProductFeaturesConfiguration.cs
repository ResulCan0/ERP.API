using System.Runtime.InteropServices.ComTypes;
using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class ProductFeaturesConfiguration : IEntityTypeConfiguration<ProductFeature>
{
    public void Configure(EntityTypeBuilder<ProductFeature> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.ProductFeatureId);
        builder.Property(_ => _.ProductFeatureId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Appearance).HasMaxLength(2);
        builder.Property(_ => _.Availabiliyt).HasMaxLength(2);
        builder.Property(_ => _.Functionality).HasMaxLength(2);
        builder.Property(_ => _.Innovation).HasMaxLength(2);
        builder.Property(_ => _.PriceAdvantage).HasMaxLength(2);
        builder.Property(_ => _.CriterionNote).HasPrecision(2,2);

        #endregion
    }
}