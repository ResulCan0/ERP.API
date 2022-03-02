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
    public class ProductDetailEntityConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            #region Primary Key
            builder.HasKey(_=>_.ProductDetailId);
            #endregion

            #region Columns
            builder.Property(_=>_.Aesthetic);
            builder.Property(_=>_.Usability);
            builder.Property(_=>_.Innovation);
            builder.Property(_=>_.Price);
            #endregion
        }
    }
}
