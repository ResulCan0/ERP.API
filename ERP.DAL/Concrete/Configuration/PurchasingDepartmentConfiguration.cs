using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class PurchasingDepartmentConfiguration : IEntityTypeConfiguration<PurchasingDepartment>
{
    public void Configure(EntityTypeBuilder<PurchasingDepartment> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.PurchasingDepartmentId);
        builder.Property(_ => _.PurchasingDepartmentId).UseIdentityColumn();

        #endregion

        #region Columns

        #region DealerProductFeatureSuggestionID --> DealerProductFeatureSuggestionID

        builder.Property(_ => _.DealerProductFeatureSuggestionId);
        builder
            .HasOne(_ => _.DealerProductFeatureSuggestion)
            .WithMany(c => c.PurchasingDepartment)
            .HasForeignKey(fk => fk.DealerProductFeatureSuggestionId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}