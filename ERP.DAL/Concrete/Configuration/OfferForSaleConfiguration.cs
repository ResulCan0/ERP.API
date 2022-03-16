using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class OfferForSaleConfiguration : IEntityTypeConfiguration<OfferForSale>
{
    public void Configure(EntityTypeBuilder<OfferForSale> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.OfferForSaleId);
        builder.Property(_ => _.OfferForSaleId).UseIdentityColumn();

        #endregion

        #region Columns

        #region DealerProductSaleID --> DealerProductSaleID

        builder.Property(_ => _.DealerProductSaleId);
        builder
            .HasOne(_ => _.DealerProductSale)
            .WithMany(c => c.OfferForSale)
            .HasForeignKey(fk => fk.DealerProductSaleId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}