using System.Runtime.InteropServices.ComTypes;
using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class DealerConfiguration : IEntityTypeConfiguration<Dealer>
{
    public void Configure(EntityTypeBuilder<Dealer> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.DealerId);
        builder.Property(_ => _.DealerId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Name).HasMaxLength(64).IsRequired();
        builder.Property(_ => _.Address).HasMaxLength(200).IsRequired();
        builder.Property(_ => _.PhoneNumber).HasMaxLength(10).IsRequired();

        #endregion
    }
}