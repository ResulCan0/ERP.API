using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.RoleId);
        builder.Property(_ => _.RoleId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.Name).HasMaxLength(20).IsRequired();

        #endregion
    }
}