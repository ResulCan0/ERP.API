using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class BuyConfiguration : IEntityTypeConfiguration<Buy>
{
    public void Configure(EntityTypeBuilder<Buy> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.BuyId);
        builder.Property(_ => _.BuyId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Amount).HasMaxLength(20).IsRequired();

        #region OfferForSaleID --> OfferForSaleID

        builder.Property(_ => _.OfferForSaleId);
        builder
            .HasOne(_ => _.OfferForSale)
            .WithMany(c => c.Buy)
            .HasForeignKey(fk => fk.OfferForSaleId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region CustomerID --> CustomerID

        builder.Property(_ => _.CustomerId);
        builder
            .HasOne(_ => _.Customer)
            .WithMany(c => c.Buy)
            .HasForeignKey(fk => fk.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}