using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sat.Recruitment.Model.DB.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Model.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.Name).IsRequired();
            entityBuilder.Property(u => u.Email).IsRequired();
            entityBuilder.Property(u => u.Address).IsRequired();
            entityBuilder.Property(u => u.Phone).IsRequired();
        }
    }
}
