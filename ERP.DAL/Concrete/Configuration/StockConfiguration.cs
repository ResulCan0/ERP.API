using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class StockConfiguration : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.StockId);
        builder.Property(_ => _.StockId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Amount).HasMaxLength(20).IsRequired();

        #region DealerID --> DealerID

        builder.Property(_ => _.DealerId);
        builder
            .HasOne(_ => _.Dealer)
            .WithMany(c => c.Stock)
            .HasForeignKey(fk => fk.DealerId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region ProducID --> ProductID

        builder.Property(_ => _.ProductId);
        builder
            .HasOne(_ => _.Product)
            .WithMany(c => c.Stock)
            .HasForeignKey(fk => fk.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}