using GNET14_EF03_EF04.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET14_EF03_EF04.Configurations
{
    internal class BranchConfig : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches");
            builder.HasKey(b => b.BranchCode);
            builder.Property(b => b.BranchCode).UseIdentityColumn();
            builder.Property(b => b.PhoneNumber).HasColumnType("varchar").HasMaxLength(12);
            builder.Property(b => b.Address).HasColumnType("varchar").HasMaxLength(20);
            

        }
    }
}
