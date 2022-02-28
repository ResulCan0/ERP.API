using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAL.Concrete.Configurations
{
    public class BuyOrderEntityConfiguration : IEntityTypeConfiguration<BuyOrder>
    {
        public void Configure(EntityTypeBuilder<BuyOrder> builder)
        {
            #region Primary Key
            builder.HasKey(x => x.OrderId);
            #endregion

            #region Columns
            #region SupplyTermsContract SupplyTermsContractId -> SupplyTermsContractId
            builder.Property(_ => _.SupplyTermsContract.SupplyTermsContractId);
            builder
                .HasOne(_ => _.SupplyTermsContract)
                .WithMany(c => c.BuyOrder)
                .HasForeignKey(fk => fk.SupplyTermsContract.SupplyTermsContractId)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion
            #endregion
        }
    }
}
