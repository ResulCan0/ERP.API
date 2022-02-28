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
    public class BidEntityConfiguration : IEntityTypeConfiguration<Bid>
    {
        public void Configure(EntityTypeBuilder<Bid> builder)
        {
            #region Primary Key
            builder.HasKey(_=>_.BidId);
            #endregion

            #region Columns
            builder.Property(_ => _.Price);

            #region BuyOrder BuyOrderId -> BuyOrderId
            builder.Property(_ => _.BuyOrder.OrderId);
            builder
                .HasOne(_ => _.BuyOrder)
                .WithMany(c => c.Bid)
                .HasForeignKey(fk => fk.BuyOrder.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
            #endregion
        }
    }
}
