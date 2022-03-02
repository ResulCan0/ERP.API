using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP.DAL.Concrete.Configurations;

public class ServiceContractEntityConfiguration:IEntityTypeConfiguration<ServiceContract>
{
    public void Configure(EntityTypeBuilder<ServiceContract> builder)
    {
        #region Primary Key

        builder.HasKey(_ => _.ServiceContractId);

        #endregion

        #region Columns

        builder.Property(_ => _.IsSıgned);

        #region ServiceContractID -> ServiceContractID

        builder.Property(_ => _.Supplier.SupplierId);
        builder
            .HasOne(_ => _.Supplier)
            .WithMany(c => c.ServiceContract)
            .HasForeignKey(fk => fk.Supplier.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);

        #endregion

        #endregion
    }
}