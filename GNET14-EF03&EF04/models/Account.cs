using GNET14_EF03_EF04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNET14_EF03_EF04.models
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public  AccountType AccountType { get; set; }

        public DateTime OpeningDate { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }

    }
}
