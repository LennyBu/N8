using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N8_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8_Data.Repositories.Configuration
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("Logins");

            builder.HasKey(b => b.Name);
            builder.Property(b => b.Name).IsRequired();

            builder.Property(b => b.Password).IsRequired();
        }
    }
}
