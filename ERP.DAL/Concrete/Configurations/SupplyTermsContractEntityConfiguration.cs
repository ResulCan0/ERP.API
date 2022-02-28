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
    public class SupplyTermsContractEntityConfiguration : IEntityTypeConfiguration<SupplyTermsContract>
    {
        public void Configure(EntityTypeBuilder<SupplyTermsContract> builder)
        {
            #region Primary Key
            builder.HasKey(_ => _.SupplyTermsContractId);
            #endregion

            #region Columns
            builder.Property(_ => _.IsSigned);
            #endregion
        }
    }
}
