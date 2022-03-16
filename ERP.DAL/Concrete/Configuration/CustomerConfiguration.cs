using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.CustomerId);
        builder.Property(_ => _.CustomerId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Name).HasMaxLength(64).IsRequired();
        builder.Property(_ => _.Surname).HasMaxLength(64).IsRequired();
        builder.Property(_ => _.Address).HasMaxLength(200).IsRequired();
        builder.Property(_ => _.PhoneNumber).HasMaxLength(64).IsRequired();

        #endregion
    }
}