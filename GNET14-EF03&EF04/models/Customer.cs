using GNET14_EF03_EF04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET14_EF03_EF04.models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Address { get; set; } = default!;
        public DateOnly  ?DateOfBirth { get; set; }
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;

        public CustomerType CustomerType { get; set; }
        public string NationalId { get; set; } = default!;
        public ICollection<AccountCustomer> AccountCustomers { get; set; } = new List<AccountCustomer>();

    }
}
