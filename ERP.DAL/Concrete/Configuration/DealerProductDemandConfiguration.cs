using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class DealerProductDemandConfiguration : IEntityTypeConfiguration<DealerProductDemand>
{
    public void Configure(EntityTypeBuilder<DealerProductDemand> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.DealerProductDemandId);
        builder.Property(_ => _.DealerProductDemandId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Amount).HasMaxLength(20).IsRequired();

        #region DealerID --> DealerID

        builder.Property(_ => _.DealerId);
        builder
            .HasOne(_ => _.Dealer)
            .WithMany(c => c.DealerProductDemand)
            .HasForeignKey(fk => fk.DealerId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region ProductID --> ProductID

        builder.Property(_ => _.ProductId);
        builder
            .HasOne(_ => _.Product)
            .WithMany(c => c.DealerProductDemand)
            .HasForeignKey(fk => fk.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion
        #endregion
    }
}