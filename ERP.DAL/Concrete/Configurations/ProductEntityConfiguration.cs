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
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            #region Primary Key
            builder.HasKey(_ => _.ProductId);
            #endregion

            #region Columns
            builder.Property(_ => _.ProductName).HasMaxLength(40);
            #endregion
        }
    }
}
