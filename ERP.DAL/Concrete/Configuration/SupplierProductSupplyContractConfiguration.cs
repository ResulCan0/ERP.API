using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configuration;

public class SupplierProductSupplyContractConfiguration : IEntityTypeConfiguration<SupplierProductSupplyContract>
{
    public void Configure(EntityTypeBuilder<SupplierProductSupplyContract> builder)
    {
        #region PrimaryKey

        builder.HasKey(_ => _.SupplierProductSupplyContractId);
        builder.Property(_ => _.SupplierProductSupplyContractId).UseIdentityColumn();

        #endregion

        #region Columns

        builder.Property(_ => _.IsSigned);
        builder.Property(_ => _.SignedDate).IsRequired();
        builder.Property(_ => _.SignedEndDate).IsRequired();

        #region ProductID --> ProductID

        builder.Property(_ => _.ProductId);
        builder
            .HasOne(_ => _.Product)
            .WithMany(c => c.SupplierProductSupplyContract)
            .HasForeignKey(fk => fk.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #region SupplierID --> SupplierID

        builder.Property(_ => _.SupplierId);
        builder
            .HasOne(_ => _.Supplier)
            .WithMany(c => c.SupplierProductSupplyContract)
            .HasForeignKey(fk => fk.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}