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
    internal class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.HasKey(b => b.AccountNumber);
            builder.Property( b=>b.AccountNumber).UseIdentityColumn();
            builder.Property(b => b.CurrentBalance).HasColumnType("decimal(10,8)");
            builder.Property(b => b.OpeningDate).HasDefaultValueSql("GETDATE()");
            builder.HasOne(a => a.Branch)
                    .WithMany(b => b.Accounts)
                     .HasForeignKey(a => a.BranchId);

        }
    }
}
