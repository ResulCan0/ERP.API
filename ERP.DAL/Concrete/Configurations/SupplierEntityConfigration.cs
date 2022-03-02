using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configurations;

public class SupplierEntityConfigration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        #region Primary Key

        builder.HasKey(_=>_.SupplierId);

        #endregion

        #region Columns

        builder.Property(_ => _.SupplierName);
        builder.Property(_ => _.SupplierPhone);
        builder.Property(_ => _.SupplierAddress);
        builder.Property(_ => _.IsServiceContractSigned);

        #region UserId -> UserId

        builder.Property(_ => _.User.UserId);
        builder
            .HasOne(_ => _.User)
            .WithMany(c => c.Supplier)
            .HasForeignKey(fk => fk.User.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}