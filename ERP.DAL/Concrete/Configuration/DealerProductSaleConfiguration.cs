using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class DealerProductSaleConfiguration: IEntityTypeConfiguration<DealerProductSale>
{
    public void Configure(EntityTypeBuilder<DealerProductSale> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.DealerProductSaleId);
        builder.Property(_ => _.DealerProductSaleId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Price).HasPrecision(18, 2).IsRequired();

        #region StockID --> StockID

        builder.Property(_ => _.StockId);
        builder
            .HasOne(_ => _.Stock)
            .WithMany(c => c.DealerProductSale)
            .HasForeignKey(fk => fk.StockId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}