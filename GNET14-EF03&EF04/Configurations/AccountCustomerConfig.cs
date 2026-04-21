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
    internal class AccountCustomerConfig : IEntityTypeConfiguration<AccountCustomer>
    {
        public void Configure(EntityTypeBuilder<AccountCustomer> builder)
        {
            builder.ToTable("AccountCustomers");
            builder.HasKey(b => new { b.CustomerId, b.AccountId });
            builder.Property(b => b.OwnerShipStartDate).HasDefaultValueSql("GETDATE()");
           
            builder.HasOne(AC => AC.Customer)
                    .WithMany(C => C.AccountCustomers)
                     .HasForeignKey(AC => AC.CustomerId);
            builder.HasOne(AC => AC.Account)
                    .WithMany(A => A.AccountCustomers)
                    .HasForeignKey(AC => AC.AccountId);

        }
    }
}
