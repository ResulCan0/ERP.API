using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class TotalAmountPayableConfiguration : IEntityTypeConfiguration<TotalAmountPayable>
{
    public void Configure(EntityTypeBuilder<TotalAmountPayable> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.TotalAmountPayableId);
        builder.Property(_ => _.TotalAmountPayableId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.TotalAmountPayablePrice).HasPrecision(18, 2);

        #region CostID --> CostID

        builder.Property(_ => _.CostId);
        builder
            .HasOne(_ => _.Cost)
            .WithMany(c => c.TotalAmountPayable)
            .HasForeignKey(fk => fk.CostId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region SupplierProductPriceID --> SupplierProductPriceID

        builder.Property(_ => _.SupplierProductPriceId);
        builder
            .HasOne(_ => _.SupplierProductPrice)
            .WithMany(c => c.TotalAmountPayable)
            .HasForeignKey(fk => fk.SupplierProductPriceId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion
        

        #endregion
    }
}