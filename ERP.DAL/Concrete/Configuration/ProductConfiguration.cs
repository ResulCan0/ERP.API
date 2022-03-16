using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.ProductId);
        builder.Property(_ => _.ProductId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Name).HasMaxLength(64).IsRequired();

        #endregion
    }
}