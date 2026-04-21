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
    internal class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(b => b.TransactionNumber);
            builder.Property(b =>b.TransactionNumber).UseIdentityColumn();
            builder.Property(b => b.Note).HasColumnType("varchar").HasMaxLength(30);
            builder.Property(b => b.Amount).HasColumnType("decimal(20,10)");
            builder.Property(b => b.TransactionDate).HasDefaultValueSql("GETDATE()");
            builder.HasOne(t => t.Account)
                    .WithMany(a => a.Transactions)
                     .HasForeignKey(t => t.AccountId);



        }
    }
}
