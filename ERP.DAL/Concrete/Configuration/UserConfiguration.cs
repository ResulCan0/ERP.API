using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.UserId);
        builder.Property(_ => _.UserId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.UserName).HasMaxLength(20).IsRequired();
        builder.Property(_ => _.PasswordHash).IsRequired();
        builder.Property(_ => _.PasswordSalt).IsRequired();

        #region RoleID --> RoleID

        builder.Property(_ => _.RoleId);
        builder
            .HasOne(_ => _.Role)
            .WithMany(c => c.User)
            .HasForeignKey(fk => fk.RoleId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}