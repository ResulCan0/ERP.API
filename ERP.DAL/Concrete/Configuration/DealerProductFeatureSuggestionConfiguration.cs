using System.Runtime.InteropServices.ComTypes;
using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class DealerProductFeatureSuggestionConfiguration : IEntityTypeConfiguration<DealerProductFeatureSuggestion>
{
    public void Configure(EntityTypeBuilder<DealerProductFeatureSuggestion> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.DealerProductFeatureSuggestionId);
        builder.Property(_ => _.DealerProductFeatureSuggestionId).UseIdentityColumn();

        #endregion

        #region Columns

        #region DealerProductDemandID --> DealerProductDemandID

        builder.Property(_ => _.DealerProductDemandId);
        builder
            .HasOne(_ => _.DealerProductDemand)
            .WithMany(c => c.DealerProductFeatureSuggestion)
            .HasForeignKey(fk => fk.DealerProductDemandId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region ProductFeaturesID --> ProductFeaturesID

        builder.Property(_ => _.ProductFeaturesId);
        builder
            .HasOne(_ => _.ProductFeatures)
            .WithMany(c => c.DealerProductFeatureSuggestion)
            .HasForeignKey(fk => fk.ProductFeaturesId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}