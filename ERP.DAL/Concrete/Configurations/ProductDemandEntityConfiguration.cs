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
    public class ProductDemandEntityConfiguration : IEntityTypeConfiguration<ProductDemand>
    {
        public void Configure(EntityTypeBuilder<ProductDemand> builder)
        {
            #region Primary Key
            builder.HasKey(_ => _.DemandId);
            #endregion

            #region Columns

            #region ProductId -> ProductId
            builder.Property(_ => _.Product.ProductId);
            builder
                .HasOne(_ => _.Product)
                .WithMany(c => c.ProductDemand)
                .HasForeignKey(fk => fk.Product.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
            #endregion
        }
    }
}
