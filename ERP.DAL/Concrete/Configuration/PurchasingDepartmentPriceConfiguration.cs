using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class PurchasingDepartmentPriceConfiguration : IEntityTypeConfiguration<PurchasingDepartmentPrice>
{
    public void Configure(EntityTypeBuilder<PurchasingDepartmentPrice> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.PurchasingDepartmentPriceId);
        builder.Property(_ => _.PurchasingDepartmentPriceId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Accepted);

        #region TotalAmountPayableID --> TotalAmountPayableID

        builder.Property(_ => _.TotalAmountPayableId);
        builder
            .HasOne(_ => _.TotalAmountPayable)
            .WithMany(c => c.PurchasingDepartmentPrice)
            .HasForeignKey(fk => fk.TotalAmountPayableId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}