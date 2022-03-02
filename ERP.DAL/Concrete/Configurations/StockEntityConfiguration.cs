using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configurations;

public class StockEntityConfiguration:IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        #region Primary Key
        builder.HasKey(_ => _.StockId);
        #endregion

        #region Columns

        builder.Property(_ => _.Quantity);

        #region ProductQualityDetailsId -> ProductQualityDetailsId

        builder.Property(_ => _.ProductQualityDetails.QualityDetailId);
           builder
            .HasOne(_ => _.ProductQualityDetails)
            .WithMany(c => c.Stock)
            .HasForeignKey(fk => fk.ProductQualityDetails.QualityDetailId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion
        
        #region ProductId -> ProductId

        builder.Property(_ => _.Product.ProductId);
        builder
            .HasOne(_ => _.Product)
            .WithMany(c => c.Stock)
            .HasForeignKey(fk => fk.Product.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
        #endregion
        
        #region DealerId -> DealerId

        builder.Property(_ => _.Dealer.DealerId);
        builder
            .HasOne(_ => _.Dealer)
            .WithMany(c => c.Stock)
            .HasForeignKey(fk => fk.Dealer.DealerId)
            .OnDelete(DeleteBehavior.Restrict);
        #endregion
        #endregion
    }
}