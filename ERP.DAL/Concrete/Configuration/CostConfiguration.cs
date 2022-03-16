using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class CostConfiguration : IEntityTypeConfiguration<Cost>
{
    public void Configure(EntityTypeBuilder<Cost> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.CostId);
        builder.Property(_ => _.CostId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.ShippingCost).HasPrecision(18, 2);
        builder.Property(_ => _.FirmCost).HasPrecision(18, 2);
        builder.Property(_ => _.BankCommission).HasPrecision(18, 2);

        #endregion
    }
}