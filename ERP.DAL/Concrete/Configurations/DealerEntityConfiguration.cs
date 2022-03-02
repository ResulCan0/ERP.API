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
    public class DealerEntityConfiguration : IEntityTypeConfiguration<Dealer>
    {
        public void Configure(EntityTypeBuilder<Dealer> builder)
        {
            #region Primary Key
            builder.HasKey(_ => _.DealerId);
            #endregion

            #region Columns
            builder.Property(_ => _.DealerName);
            builder.Property(_ => _.DealerAddress);

            #region UserId -> UserId
            builder.Property(_ => _.User.UserId);
            builder
                .HasOne(_ => _.User)
                .WithMany(c => c.Dealer)
                .HasForeignKey(fk => fk.User.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
            
            #endregion
        }
    }
}
