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
    internal class ManagerConfig : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Managers");
            builder.HasKey(b => b.Id);
            builder.Property(b=>b.Id).UseIdentityColumn();
            builder.Property(b => b.PhoneNumber).HasMaxLength(12).HasColumnType("varchar");
            builder.Property(b => b.FullName).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(b => b.HireDate).HasDefaultValueSql("GETDATE()");
            builder.HasOne(b => b.ManagedBranch)
                    .WithOne(b => b.BranchManager)
                     .HasForeignKey<Branch>(b => b.ManagerId);

        }
    }
}
