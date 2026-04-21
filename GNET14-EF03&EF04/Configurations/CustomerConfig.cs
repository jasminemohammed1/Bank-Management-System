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
    internal class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).UseIdentityColumn();
            builder.Property(b => b.NationalId).HasColumnType("varchar").HasMaxLength(30);
            builder.Property(b => b.Address).HasColumnType("varchar").HasMaxLength(30);
            builder.Property(b =>b.Email).HasColumnType("varchar").HasMaxLength(40).IsRequired();
            builder.Property(b => b.FullName).HasColumnType("varchar").HasMaxLength(30);
        }
    }
}
