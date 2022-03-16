using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.SupplierId);
        builder.Property(_ => _.SupplierId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Name).HasMaxLength(64).IsRequired();
        builder.Property(_ => _.Address).HasMaxLength(200).IsRequired();
        builder.Property(_ => _.PhoneNumber).HasMaxLength(10).IsRequired();

        #endregion
    }
}