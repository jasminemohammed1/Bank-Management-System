using GNET14_EF03_EF04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET14_EF03_EF04.models
{
    internal class AccountCustomer

    {
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public DateTime OwnerShipStartDate {  get; set; }
        public OwnerShipType OwnerShipType { get; set; }

        public AccountType AccountType { get; set; }


    }
    
}
