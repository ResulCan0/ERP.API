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
    public class UserEntityRepository : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            #region Primary Key
            builder.HasKey(_=>_.UserId);
            #endregion

            #region Columns
            builder.Property(_=>_.UserName);
            builder.Property(_=>_.PasswordHash);
            builder.Property(_=>_.PasswordSalt);
            #endregion
        }
    }
}
